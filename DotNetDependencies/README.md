## Semantic Sersioning

There's an industry standard called semantic versioning, which is how you express the type of change that you or some other developer is introducing to a library. Semantic versioning works by ensuring that a package has a version number, and that the version number is divided into these sections:

- Major version: The leftmost number. For example, it's the 1 in 1.0.0. A change to this number means that you can expect breaking changes in code. You might need to rewrite part of your code.
- Minor version: The middle number. For example, it's the 2 in 1.2.0. A change to this number means that features have been added. Your code should still work. It's generally safe to accept the update.
- Patch version: The rightmost number. For example, it's the 3 in 1.2.3. A change to this number means that a change has been applied that fixes something in the code that should have worked. It should be safe to accept the update.

## NuGet version rules

| Notation  | Applied rule  | Description                                           |
| --------- | ------------- | ----------------------------------------------------- |
| 1.0       | x >= 1.0      | Minimum version, inclusive                            |
| (1.0,)    | x > 1.0       | Minimum version, exclusive                            |
| [1.0]     | x == 1.0      | Exact version match                                   |
| (,1.0]    | x ≤ 1.0       | Maximum version, inclusive                            |
| (,1.0)    | x < 1.0       | Maximum version, exclusive                            |
| [1.0,2.0] | 1.0 ≤ x ≤ 2.0 | Exact range, inclusive                                |
| (1.0,2.0) | 1.0 < x < 2.0 | Exact range, exclusive                                |
| [1.0,2.0) | 1.0 ≤ x < 2.0 | Mixed inclusive minimum and exclusive maximum version |
| (1.0)     | invalid       | invalid                                               |

Example:

```XML
<!-- Accepts any version 6.1 and later. -->
<PackageReference Include="ExamplePackage" Version="6.1" />

<!-- Accepts any 6.x.y version. -->
<PackageReference Include="ExamplePackage" Version="6.*" />
<PackageReference Include="ExamplePackage" Version="[6,7)" />

<!-- Accepts any later version, but not including 4.1.3. Could be
     used to guarantee a dependency with a specific bug fix. -->
<PackageReference Include="ExamplePackage" Version="(4.1.3,)" />

<!-- Accepts any version earlier than 5.x, which might be used to prevent pulling in a later
     version of a dependency that changed its interface. However, we don't recommend this form because determining the earliest version can be difficult. -->
<PackageReference Include="ExamplePackage" Version="(,5.0)" />

<!-- Accepts any 1.x or 2.x version, but not 0.x or 3.x and later. -->
<PackageReference Include="ExamplePackage" Version="[1,3)" />

<!-- Accepts 1.3.2 up to 1.4.x, but not 1.5 and later. -->
<PackageReference Include="ExamplePackage" Version="[1.3.2,1.5)" />
```
