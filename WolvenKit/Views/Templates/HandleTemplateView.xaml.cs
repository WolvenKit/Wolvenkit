using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Reflection;
using UserControl = System.Windows.Controls.UserControl;

namespace WolvenKit.Views.Templates
{
    /// <summary>
    /// Interaction logic for EnumTemplateView.xaml
    /// </summary>
    public partial class HandleTemplateView : UserControl
    {
        public HandleTemplateView()
        {
            InitializeComponent();
        }

        public ICR2WExport SelectedItem { get; set; }

        public ObservableCollection<ICR2WExport> BindingCollection { get; set; } = new();

        public IChunkPtrAccessor RedChunkPtr
        {
            get => (IChunkPtrAccessor)GetValue(RedChunkPtrProperty);
            set => SetValue(RedChunkPtrProperty, value);
        }

        public static readonly DependencyProperty RedChunkPtrProperty =
            DependencyProperty.Register(nameof(RedChunkPtr), typeof(IChunkPtrAccessor),
                typeof(HandleTemplateView), new PropertyMetadata(OnRedChunkPtrChanged));


        private static void OnRedChunkPtrChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not HandleTemplateView view)
            {
                return;
            }
            if (view.RedChunkPtr == null)
            {
                return;
            }
            if (e.NewValue is not IChunkPtrAccessor iptr)
            {
                return;
            }

            view.BindingCollection.Clear();

            // get all possible chunks in the cr2w file
            var reftype = AssemblyDictionary.GetTypeByName(iptr.ReferenceType);
            var available = AssemblyDictionary.GetSubClassesOf(reftype).Select(x => x.Name);

            var availableChunks = iptr.Cr2wFile.Chunks.Where(x => available.Contains(x.REDType));

            foreach (var s in availableChunks)
            {
                view.BindingCollection.Add(s);
            }

            view.SelectedItem = iptr.Reference;
        }

        

        private void ComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RedChunkPtr is not IChunkPtrAccessor cvar)
            {
                return;
            }

            if (cvar.Reference == SelectedItem)
            {
                return;
            }

            cvar.SetValue(SelectedItem);
            cvar.IsSerialized = true;
        }
    }
}
