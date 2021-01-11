﻿using Catel;
using Catel.MVVM;
using Orchestra.Services;

namespace WolvenKit.Commands
{
    public class ApplicationAboutCommandContainer : Catel.MVVM.CommandContainerBase
    {
        private readonly IAboutService _aboutService;

        public ApplicationAboutCommandContainer(ICommandManager commandManager, IAboutService aboutService)
            : base(AppCommands.Application.About, commandManager)
        {
            Argument.IsNotNull(() => aboutService);

            _aboutService = aboutService;
        }

        protected override void Execute(object parameter)
        {
            _aboutService.ShowAboutAsync();
        }
    }
}