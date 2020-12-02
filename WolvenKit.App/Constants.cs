﻿using System.Collections.Immutable;
using System.Windows.Input;
using Orc.Squirrel;
using InputGesture = Catel.Windows.Input.InputGesture;

namespace WolvenKit.App
{
    public static class AppCommands
    {
        public static class Application
        {
            public const string Exit = "Application.Exit";
            public static readonly InputGesture ExitInputGesture = new InputGesture(Key.F4, ModifierKeys.Alt);

            public const string About = "Application.About";
            public static readonly InputGesture AboutInputGesture = new InputGesture(Key.F1);

            public const string Options = "Application.Options";
            public static readonly InputGesture OptionsInputGesture = new InputGesture(Key.F12);


            public const string OpenProject = "Application.OpenProject";
            public static readonly InputGesture OpenProjectInputGesture = new InputGesture(Key.O, ModifierKeys.Control);
            public const string NewProject = "Application.NewProject";
            public static readonly InputGesture NewProjectInputGesture = new InputGesture(Key.N, ModifierKeys.Control);

            //public const string SaveAll = "Application.SaveAll";
            //public static readonly InputGesture SaveAllInputGesture = new InputGesture(Key.S, ModifierKeys.Control);


            public const string ShowLog = "Application.ShowLog";
            public const string ShowProjectExplorer = "Application.ShowProjectExplorer";
            public const string ShowImportUtility = "Application.ShowImportUtility";

            public const string ShowAssetBrowser = "Application.ShowAssetBrowser";
            public const string ShowModSettings = "Application.ShowModSettings";
            public const string ShowPackageInstaller = "Application.ShowPackageInstaller";
            
            public const string OpenFile = "Application.OpenFile";
            public const string NewFile = "Application.NewFile";

            public const string PackMod = "Application.PackMod";
            public const string BackupMod = "Application.BackupMod";



            public const string ViewSelected = "Application.ViewSelected";

            #region Project Explorer
            public const string ExpandAll = "Application.ExpandAll";
            public const string CollapseAll = "Application.CollapseAll";
            public const string Expand = "Application.Expand";
            public const string Collapse = "Application.Collapse";
            #endregion


        }
    }

    public static class Settings
    {
        public static class Application
        {
            public static class General
            {
                public const string SomeSetting = "General.SomeSetting";
                public const bool SomeSettingDefaultValue = true;
            }

            public static class AutomaticUpdates
            {
                public const bool CheckForUpdatesDefaultValue = true;

                public static readonly ImmutableArray<UpdateChannel> AvailableChannels = ImmutableArray.Create(
                    new UpdateChannel("Stable", "XXX"),     //TODO
                    new UpdateChannel("Beta", "XXX")        //TODO
                );

                public static readonly UpdateChannel DefaultChannel = AvailableChannels[0];
            }
        }
    }
}