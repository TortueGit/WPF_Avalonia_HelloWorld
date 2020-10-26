#########################################################################################
#                                AVALONIA PROJECT HELPER                                #
#########################################################################################

1) Get the avalonia dotnet templates on https://github.com/AvaloniaUI/avalonia-dotnet-templates

    - Clone the github repository
    - Install the templates with the command line 'dotnet new --install [path-to-repository]'
            Avalonia should be appears on the dotnet templates list :
                Templates                   Short Name         Language        Tags
                --------------------------------------------------------------------------
                [...]
                Avalonia .NET Core App      avalonia.app         [C#]          ui/xaml
                Avalonia .NET Core MVVM App avalonia.mvvm        [C#]          ui/xaml
                Avalonia UserControl        avalonia.usercontrol [C#]          ui/xaml
                Avalonia Window             avalonia.window      [C#]          ui/xaml

2) Creating 

    a) a new MVVM Application

        'dotnet new avalonia.mvvm -o MyApp'
    
    b) a new Application

        'dotnet new avalonia.app -o MyApp'

    c) a new Window

        'dotnet new avalonia.window -na MyApp -n MyNewWindow'

    d) a new UserControl

        'dotnet new avalonia.usercontrol -na MyApp -n MyNewView'

    e) a new Styles list

        'dotnet new avalonia.styles -n MyStyles'

    f) a new ResourceDictionary

        'dotnet new avalonia.resource -n MyResources'
