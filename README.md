
<!-- default file list -->
*Files to look at*:

* [AutofacDI](./CS/AutofacDI/App.xaml.cs)
* [DryIocDI](./CS/DryIocDI/App.xaml.cs)
* [MicrosoftDI](./CS/MicrosoftDI/App.xaml.cs)
* [NinjectDI](./CS/NinjectDI/App.xaml.cs)
* [PrismDI](./CS/PrismDI/App.xaml.cs)
* [SimpleInjectorDI](./CS/SimpleInjectorDI/App.xaml.cs)
* [UnityDI](./CS/UnityDI/App.xaml.cs)
<!-- default file list end -->

# How to use DevExpress Services with Dependency Injection

Use the AttachServiceBehavior to register services that require a specific view (such as FrameNavigationService, TabbedDocumentUIService, WizardService):

```
<dxwui:NavigationFrame>
    <dxmvvm:Interaction.Behaviors>
        <common:AttachServiceBehavior Service="{Binding NavigationService}"/>
    </dxmvvm:Interaction.Behaviors>
</dxwui:NavigationFrame>
```

Inject the service in the ViewModel's constructor:

```
public class MainViewModel {
    public INavigationService NavigationService { get; }

    public MainViewModel(INavigationService navigationService) => NavigationService = navigationService;
}
```

This example illustrates how to apply this technique to use the NavigationService with Dependency Injection.

<br/>
