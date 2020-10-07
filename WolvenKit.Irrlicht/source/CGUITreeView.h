// This file is part of the "Irrlicht Engine".
// written by Reinhard Ostermeier, reinhard@nospam.r-ostermeier.de

#ifndef __C_GUI_TREE_VIEW_H_INCLUDED__
#define __C_GUI_TREE_VIEW_H_INCLUDED__

#include "IGUITreeView.h"
#include "irrList.h"


namespace irr
{
namespace gui
{
	// forward declarations
	class IGUIFont;
	class IGUIScrollBar;
	class CGUITreeView;

	//! Node for gui tree view
	class CGUITreeViewNode : public IGUITreeViewNode
	{
	friend class CGUITreeView;

	public:
		//! constructor
		CGUITreeViewNode( CGUITreeView* owner, CGUITreeViewNode* parent );

		//! destructor
		~CGUITreeViewNode();

		//! returns the owner (tree view) of this node
		IGUITreeView* getOwner() const _IRR_OVERRIDE_;

		//! Returns the parent node of this node.
		IGUITreeViewNode* getParent() const _IRR_OVERRIDE_;

		//! returns the text of the node
		const wchar_t* getText() const _IRR_OVERRIDE_
		{ return Text.c_str(); }

		//! sets the text of the node
		void setText( const wchar_t* text ) _IRR_OVERRIDE_;

		//! returns the icon text of the node
		const wchar_t* getIcon() const _IRR_OVERRIDE_
		{ return Icon.c_str(); }

		//! sets the icon text of the node
		void setIcon( const wchar_t* icon ) _IRR_OVERRIDE_;

		//! returns the image index of the node
		u32 getImageIndex() const _IRR_OVERRIDE_
		{ return ImageIndex; }

		//! sets the image index of the node
		void setImageIndex( u32 imageIndex ) _IRR_OVERRIDE_
		{ ImageIndex = imageIndex; }

		//! returns the image index of the node
		u32 getSelectedImageIndex() const _IRR_OVERRIDE_
		{ return SelectedImageIndex; }

		//! sets the image index of the node
		void setSelectedImageIndex( u32 imageIndex ) _IRR_OVERRIDE_
		{ SelectedImageIndex = imageIndex; }

		//! returns the user data (void*) of this node
		void* getData() const _IRR_OVERRIDE_
		{ return Data; }

		//! sets the user data (void*) of this node
		void setData( void* data ) _IRR_OVERRIDE_
		{ Data = data; }

		//! returns the user data2 (IReferenceCounted) of this node
		IReferenceCounted* getData2() const _IRR_OVERRIDE_
		{ return Data2; }

		//! sets the user data2 (IReferenceCounted) of this node
		void setData2( IReferenceCounted* data ) _IRR_OVERRIDE_
		{
			if( Data2 )
			{
				Data2->drop();
			}
			Data2 = data;
			if( Data2 )
			{
				Data2->grab();
			}
		}

		//! returns the child item count
		u32 getChildCount() const _IRR_OVERRIDE_
		{ return Children.getSize(); }

		//! removes all children (recursive) from this node
		void clearChildren() _IRR_OVERRIDE_;

		//! returns true if this node has child nodes
		bool hasChildren() const _IRR_OVERRIDE_
		{ return !Children.empty(); }

		//! Adds a new node behind the last child node.
		//! \param text text of the new node
		//! \param icon icon text of the new node
		//! \param imageIndex index of the image for the new node (-1 = none)
		//! \param selectedImageIndex index of the selected image for the new node (-1 = same as imageIndex)
		//! \param data user data (void*) of the new node
		//! \param data2 user data2 (IReferenceCounted*) of the new node
		//! \return
		//! returns the new node
		IGUITreeViewNode* addChildBack(
				const wchar_t* text,
				const wchar_t* icon = 0,
				s32 imageIndex = -1,
				s32 selectedImageIndex = -1,
				void* data = 0,
				IReferenceCounted* data2 = 0) _IRR_OVERRIDE_;

		//! Adds a new node before the first child node.
		//! \param text text of the new node
		//! \param icon icon text of the new node
		//! \param imageIndex index of the image for the new node (-1 = none)
		//! \param selectedImageIndex index of the selected image for the new node (-1 = same as imageIndex)
		//! \param data user data (void*) of the new node
		//! \param data2 user data2 (IReferenceCounted*) of the new node
		//! \return
		//! returns the new node
		IGUITreeViewNode* addChildFront(
				const wchar_t*		text,
				const wchar_t*		icon = 0,
				s32					imageIndex = -1,
				s32					selectedImageIndex = -1,
				void*					data = 0,
				IReferenceCounted*			data2 = 0 ) _IRR_OVERRIDE_;

		//! Adds a new node behind the other node.
		//! The other node has also te be a child node from this node.
		//! \param text text of the new node
		//! \param icon icon text of the new node
		//! \param imageIndex index of the image for the new node (-1 = none)
		//! \param selectedImageIndex index of the selected image for the new node (-1 = same as imageIndex)
		//! \param data user data (void*) of the new node
		//! \param data2 user data2 (IReferenceCounted*) of the new node
		//! \return
		//! returns the new node or 0 if other is no child node from this
		IGUITreeViewNode* insertChildAfter(
				IGUITreeViewNode*	other,
				const wchar_t*		text,
				const wchar_t*		icon = 0,
				s32					imageIndex = -1,
				s32					selectedImageIndex = -1,
				void*					data = 0,
				IReferenceCounted*			data2 = 0 ) _IRR_OVERRIDE_;

		//! Adds a new node before the other node.
		//! The other node has also te be a child node from this node.
		//! \param text text of the new node
		//! \param icon icon text of the new node
		//! \param imageIndex index of the image for the new node (-1 = none)
		//! \param selectedImageIndex index of the selected image for the new node (-1 = same as imageIndex)
		//! \param data user data (void*) of the new node
		//! \param data2 user data2 (IReferenceCounted*) of the new node
		//! \return
		//! returns the new node or 0 if other is no child node from this
		IGUITreeViewNode* insertChildBefore(
				IGUITreeViewNode*	other,
				const wchar_t*		text,
				const wchar_t*		icon = 0,
				s32					imageIndex = -1,
				s32					selectedImageIndex = -1,
				void*					data = 0,
				IReferenceCounted*			data2 = 0 ) _IRR_OVERRIDE_;

		//! Return the first child note from this node.
		IGUITreeViewNode* getFirstChild() const _IRR_OVERRIDE_;

		//! Return the last child note from this node.
		IGUITreeViewNode* getLastChild() const _IRR_OVERRIDE_;

		//! Returns the preverse sibling node from this node.
		IGUITreeViewNode* getPrevSibling() const _IRR_OVERRIDE_;

		//! Returns the next sibling node from this node.
		IGUITreeViewNode* getNextSibling() const _IRR_OVERRIDE_;

		//! Returns the next visible (expanded, may be out of scrolling) node from this node.
		IGUITreeViewNode* getNextVisible() const _IRR_OVERRIDE_;

		//! Deletes a child node.
		bool deleteChild( IGUITreeViewNode* child ) _IRR_OVERRIDE_;

		//! Moves a child node one position up.
		bool moveChildUp( IGUITreeViewNode* child ) _IRR_OVERRIDE_;

		//! Moves a child node one position down.
		bool moveChildDown( IGUITreeViewNode* child ) _IRR_OVERRIDE_;

		//! Returns true if the node is expanded (children are visible).
		bool getExpanded() const _IRR_OVERRIDE_
		{ return Expanded; }

		//! Sets if the node is expanded.
		void setExpanded( bool expanded ) _IRR_OVERRIDE_;

		//! Returns true if the node is currently selected.
		bool getSelected() const _IRR_OVERRIDE_;

		//! Sets this node as selected.
		void setSelected( bool selected ) _IRR_OVERRIDE_;

		//! Returns true if this node is the root node.
		bool isRoot() const _IRR_OVERRIDE_;

		//! Returns the level of this node.
		s32 getLevel() const _IRR_OVERRIDE_;

		//! Returns true if this node is visible (all parents are expanded).
		bool isVisible() const _IRR_OVERRIDE_;

	private:

		CGUITreeView*			Owner;
		CGUITreeViewNode*		Parent;
		core::stringw			Text;
		core::stringw			Icon;
		s32				ImageIndex;
		s32				SelectedImageIndex;
		void*				Data;
		IReferenceCounted*		Data2;
		bool				Expanded;
		core::list<CGUITreeViewNode*>	Children;
	};


	//! Default tree view GUI element.
	class CGUITreeView : public IGUITreeView
	{
	friend class CGUITreeViewNode;

	public:
		//! constructor
		CGUITreeView( IGUIEnvironment* environment, IGUIElement* parent,
			s32 id, core::rect<s32> rectangle, bool clip = true,
			bool drawBack = false, bool scrollBarVertical = true, bool scrollBarHorizontal = true );

		//! destructor
		~CGUITreeView();

		//! returns the root node (not visible) from the tree.
		IGUITreeViewNode* getRoot() const _IRR_OVERRIDE_
		{ return Root; }

		//! returns the selected node of the tree or 0 if none is selected
		IGUITreeViewNode* getSelected() const _IRR_OVERRIDE_
		{ return Selected; }

		//! returns true if the tree lines are visible
		bool getLinesVisible() const _IRR_OVERRIDE_
		{ return LinesVisible; }

		//! sets if the tree lines are visible
		void setLinesVisible( bool visible ) _IRR_OVERRIDE_
		{ LinesVisible = visible; }

		//! called if an event happened.
		bool OnEvent( const SEvent &event ) _IRR_OVERRIDE_;

		//! draws the element and its children
		void draw() _IRR_OVERRIDE_;

		//! Sets the font which should be used as icon font. This font is set to the Irrlicht engine
		//! built-in-font by default. Icons can be displayed in front of every list item.
		//! An icon is a string, displayed with the icon font. When using the build-in-font of the
		//! Irrlicht engine as icon font, the icon strings defined in GUIIcons.h can be used.
		void setIconFont( IGUIFont* font ) _IRR_OVERRIDE_;

		//! Sets a skin independent font.
		/** \param font: New font to set or 0 to use the skin-font. */
		void setOverrideFont(IGUIFont* font=0) _IRR_OVERRIDE_;

		//! Gets the override font (if any)
		/** \return The override font (may be 0) */
		IGUIFont* getOverrideFont(void) const _IRR_OVERRIDE_;

		//! Get the font which is used for drawing
		/** This is the override font when one is set and the
		font of the skin otherwise. */
		IGUIFont* getActiveFont() const _IRR_OVERRIDE_;

		//! Sets the image list which should be used for the image and selected image of every node.
		//! The default is 0 (no images).
		void setImageList( IGUIImageList* imageList ) _IRR_OVERRIDE_;

		//! Returns the image list which is used for the nodes.
		IGUIImageList* getImageList() const _IRR_OVERRIDE_
		{ return ImageList; }

		//! Sets if the image is left of the icon. Default is true.
		void setImageLeftOfIcon( bool bLeftOf ) _IRR_OVERRIDE_
		{ ImageLeftOfIcon = bLeftOf; }

		//! Returns if the Image is left of the icon. Default is true.
		bool getImageLeftOfIcon() const _IRR_OVERRIDE_
		{ return ImageLeftOfIcon; }

		//! Returns the node which is associated to the last event.
		IGUITreeViewNode* getLastEventNode() const _IRR_OVERRIDE_
		{ return LastEventNode; }

		//! Access the vertical scrollbar
		IGUIScrollBar* getVerticalScrollBar() const noexcept _IRR_OVERRIDE_;

		//! Access the horizontal scrollbar
		IGUIScrollBar* getHorizontalScrollBar() const noexcept _IRR_OVERRIDE_;

	private:
		//! calculates the heigth of an node and of all visible nodes.
		void recalculateItemHeight();

		//! Resize scrollbars when their size in the skin has changed
		void updateScrollBarSize(s32 size);

		//! executes an mouse action (like selectNew of CGUIListBox)
		void mouseAction( s32 xpos, s32 ypos, bool onlyHover = false );

		CGUITreeViewNode*	Root;
		IGUITreeViewNode*	Selected;
		s32			ItemHeight;
		s32			IndentWidth;
		s32			TotalItemHeight;
		s32			TotalItemWidth;
		s32			ScrollBarSize;
		IGUIFont*		Font;
		gui::IGUIFont*	OverrideFont;
		IGUIFont*		IconFont;
		IGUIScrollBar*		ScrollBarH;
		IGUIScrollBar*		ScrollBarV;
		IGUIImageList*		ImageList;
		IGUITreeViewNode*	LastEventNode;
		bool			LinesVisible;
		bool			Selecting;
		bool			Clip;
		bool			DrawBack;
		bool			ImageLeftOfIcon;
	};


} // end namespace gui
} // end namespace irr

#endif

