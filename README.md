<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/400430029/20.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1038933)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# DevExpress MVVM Framework - Use DevExpress Services with a Dependency Injection

This example illustrates how to use the `NavigationService` with Dependency Injection.

Use the `AttachServiceBehavior` to register services that require a specific view (such as [FrameNavigationService](https://docs.devexpress.com/WPF/113944/mvvm-framework/services/predefined-set/framenavigationservice), [TabbedDocumentUIService](https://docs.devexpress.com/WPF/18173/mvvm-framework/services/predefined-set/document-services/tabbeddocumentuiservice), [WizardService](https://docs.devexpress.com/WPF/116321/mvvm-framework/services/predefined-set/wizardservice)):

``` xaml
<dxwui:NavigationFrame>
    <dxmvvm:Interaction.Behaviors>
        <common:AttachServiceBehavior Service="{Binding NavigationService}"/>
    </dxmvvm:Interaction.Behaviors>
</dxwui:NavigationFrame>
```

Inject the service in the ViewModel's constructor:

``` c#
public class MainViewModel {
    public INavigationService NavigationService { get; }

    public MainViewModel(INavigationService navigationService) =>
        NavigationService = navigationService;
}
```

<!-- default file list -->
## Files to Look At

* [MainViewModel.cs](./CS/FrameNavigation/ViewModel/MainViewModel.cs)
* [MainView.xaml](./CS/FrameNavigation/View/MainView.xaml)
* [AttachServiceBehavior.cs](./CS/FrameNavigation/Common/AttachServiceBehavior.cs)
<!-- default file list end -->

## Documentation

* [Use Services with Dependency Injection](https://docs.devexpress.com/WPF/403514/mvvm-framework/dependency-injection#use-services-with-dependency-injection)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-framework-use-services-with-dependency-injection&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-mvvm-framework-use-services-with-dependency-injection&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
