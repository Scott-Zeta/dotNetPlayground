## Can not access https when running

```bash
dotnet watch --launch-profile https
```

[My Anwser Reference](https://learn.microsoft.com/en-us/answers/questions/1297509/how-to-fix-this-error-warn-microsoft-aspnetcore-ht?page=1&orderby=newest#answers)

## A typical Razor page

- **[pageName].cshtml**:
  Manage the front-end aspect like view and layout ... everything about the vision.

  ```razor
  @{...}
  ```

  The Block is similar to JS/TS logic in a React component

  ```razor
  <div>...</div>
  ```

  This Block is more like the return section in a React components control the dom rendering.

- **[pageName].cshtml.cs**:
  Manage the back-end aspect like how server action interact with the page, such as request, providing data ... and everything about logic.

## Tage Helpers

These attributes are designed for specific element tags. Not likely to use in other tags.

- **Partial Tag Helper**:

```razor
<partial name="_ValidationScriptsPartial" />
```

Insert another cshtml file into the current page. Can use both for JS logic or Dom layout. Similar to the React reusable components.

- **Label Tag Helper**:

```razor
<label asp-for="Foo.Id" class="control-label"></label>
```

Bind a dynamic value from the Model to the label. Typically like the

```react
<p>${dynamicValue}</p>
```

**Not very clear for the control-label part for now. Is that for CSS?**

- **Input tag helper**:

```razor
<input asp-for="Foo.Id" class="form-control" />
```

Bind the value in input box to the model's value for input.

- **Validation Summary Tag Helper**

```razor
<div asp-validation-summary="All"></div>
```

This is just a div section for validation vision summary. It does not include in validation logic.

### A Typical approach

- [SomeModel].cs include the data model and validation logic.
- [SomePage].cshtml.cs include the page interaction logic.
- [SomePage].cshtml include the vision of the page.

# Starter app for Create a web UI with ASP.NET Core

Welcome! This is the starter app for the [Create a web UI with ASP.NET Core](https://learn.microsoft.com/training/modules/create-razor-pages-aspnet-core/) Microsoft Training module.

## Completed version

The completed version of this module is available on the `solution` branch of this repo.

## Contributing

This project welcomes contributions and suggestions. Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Legal Notices

Microsoft and any contributors grant you a license to the Microsoft documentation and other content
in this repository under the [Creative Commons Attribution 4.0 International Public License](https://creativecommons.org/licenses/by/4.0/legalcode),
see the [LICENSE](LICENSE) file, and grant you a license to any code in the repository under the [MIT License](https://opensource.org/licenses/MIT), see the
[LICENSE-CODE](LICENSE-CODE) file.

Microsoft, Windows, Microsoft Azure and/or other Microsoft products and services referenced in the documentation
may be either trademarks or registered trademarks of Microsoft in the United States and/or other countries.
The licenses for this project do not grant you rights to use any Microsoft names, logos, or trademarks.
Microsoft's general trademark guidelines can be found at http://go.microsoft.com/fwlink/?LinkID=254653.

Privacy information can be found at https://privacy.microsoft.com/en-us/

Microsoft and any contributors reserve all other rights, whether under their respective copyrights, patents,
or trademarks, whether by implication, estoppel or otherwise.
