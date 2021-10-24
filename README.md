
<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/ViewModel/MainViewModel.cs)
* [MainView.xaml](./CS/View/MainView.xaml)
* [AttachServiceBehavior.cs](./CS/Common/AttachServiceBehavior.cs)
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
