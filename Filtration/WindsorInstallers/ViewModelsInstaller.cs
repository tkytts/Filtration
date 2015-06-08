﻿using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Filtration.ViewModels;

namespace Filtration.WindsorInstallers
{
    public class ViewModelsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IMainWindowViewModel>()
                    .ImplementedBy<MainWindowViewModel>()
                    .LifeStyle.Transient);

            container.Register(
                Component.For<IItemFilterBlockViewModel>()
                    .ImplementedBy<ItemFilterBlockViewModel>()
                    .LifeStyle.Transient);

            container.Register(
                Component.For<IItemFilterScriptViewModel>()
                    .ImplementedBy<ItemFilterScriptViewModel>()
                    .LifeStyle.Transient);

            container.Register(
                Component.For<IReplaceColorsViewModel>()
                    .ImplementedBy<ReplaceColorsViewModel>()
                    .LifeStyle.Singleton);

            container.AddFacility<TypedFactoryFacility>();
            container.Register(
                Component.For<IItemFilterBlockViewModelFactory>().AsFactory());

            container.Register(
                Component.For<IItemFilterScriptViewModelFactory>().AsFactory());
        }
    }
}
