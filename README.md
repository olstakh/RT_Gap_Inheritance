# Structure

`ProviderDependency` project has a base class
`Provider` project inherits from it
`Consumer` project inherits from `Provider`'s class

# Details
When `Consumer` references `Provider` - it also needs to reference `ProviderDependency`, since it's part of type hierarchy.

When `<DisableTransitiveProjectReferences>` is set to `true` - `Consumer` needs to explicitly reference `ProviderDependency`, since it won't flow on its own.

Currently it produces `RT0002` warning, and if you remove that references - build will be failing.
RT needs to account for type hierarchy when marking assemblies as used.