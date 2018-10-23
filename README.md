# Lab11-MyFirstMVCApp

This is my first MVC .NET Core Web Application written in C#. The goal of this project is to get familiar with the procedural steps of setting up a .NET Core 2.1 web application. Instead of using the `Web Application` scaffolding, this project was initialized from the `Empty` option in the Visual Studio GUI.

The basic functions of this application are to search by form on the /Home page, which routes to the view /Views/Home/Index by default. This form queries a generic `List` collection of `TimePerson` objects. `TimePerson` objects have been created from a parsed .csv file of raw data. This is provided by TIME Magazine's People of the Year data.

After the user inputs a range of years, the user will be redirected to a results page that formats and displays the matching collection of `TimePerson` objects within the scope of years the user has queried.

## Sample Views

![GetHomeIndex](https://github.com/rh24/Lab11-MyFirstMVCApp/blob/RebeccaHong-Lab11/assets/HomeIndex.png)
![RedirectToResult](https://github.com/rh24/Lab11-MyFirstMVCApp/blob/RebeccaHong-Lab11/assets/HomeResult.png)

## Resources

* [Code Fellows - .NET 401 Guide to First MVC App](https://codefellows.github.io/code-401-dotnet-guide/Curriculum/Class11/Resources/MVCSetup.html)
* [Raw CSV Data](https://github.com/codefellows/seattle-dotnet-401d5/blob/master/Class11-MVC/Resources/personOfTheYear.csv)
* Parsing code provided by Amanda Iverson, Instructor for .NET 401 course.

## Contributing

Bug reports and pull requests are welcome on GitHub at https://github.com/rh24/Lab11-MyFirstMVCApp. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the Contributor Covenant code of conduct.

## License

The web application is available as open source under the terms of the [MIT License](https://opensource.org/licenses/MIT).
