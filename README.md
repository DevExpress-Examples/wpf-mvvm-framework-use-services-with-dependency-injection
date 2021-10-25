<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/400430029/20.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1038933)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainViewModel.cs](./CS/FrameNavigation/ViewModel/MainViewModel.cs)
* [MainView.xaml](./CS/FrameNavigation/View/MainView.xaml)
* [AttachServiceBehavior.cs](./CS/FrameNavigation/Common/AttachServiceBehavior.cs)
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

    public MainViewModel(INavigationService navigationService) =>
        NavigationService = navigationService;
}
```

This example illustrates how to apply this technique to use the NavigationService with Dependency Injection.

<br/>
