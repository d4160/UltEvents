// UltEvents v2.1 //

- Added `UltEventBase.DynamicInvoke` which takes an `object[]`.
- Added a display option for "Use Indentation" to optionally fill the full Inspector width instead of indenting properly.
- Flipped the `Get` and `Set` toggles for properties. `Get` is now shown when the getter is selected rather than as a button to change to the getter.
- Fixed exception caused by the UI Elements system when resizing arrays containing UltEvents.
- Fixed a few GUI spacing issues in Unity 2019.3+.
- Fixed the `Click to add a listener` label to not disappear when opening the context menu.
- Refactored `SerializedPropertyReference` into `Serialization.PropertyReference`.

// UltEvents v2.0 //

- Moved everything out of the precompiled DLL to make it easier to access and modify the source code.
- WARNING: when upgrading from an earlier version you must delete the old version before importing the new one. This will also cause all of the Premade Event Scripts in your project to go missing so you will need to set them all up again. This is an unfortunate side effect of the way Unity handles references to scripts inside a DLL compared to regular script files.
- Replaced PDF user manual with a website hosted at https://kybernetikgames.github.io/ultevents.
- Added support for constructors.
- Added interfaces corresponding to all UltEvent types so that the ability to add and remove listeners can be exposed without exposing the ability to invoke, clear, or access other members of the event.
- Fixed cached PersistentArgument values to be cleared properly when the user modifies the argument in the Inspector.
- Removed the Parameter Constructors sub-menu because it isn't particularly useful now that actual constructors are supported.

// UltEvents v1.2 //

- Fixed an issue where persistent arguments using parameters or returned values would cache the first value they were given and keep using that.
- Changed structure of source code project back to having the Runtime project link all the files in the Editor project. Shared Projects are more hassle than they're worth.

// UltEvents v1.1 //

- Fixed invocation to not allocate garbage every time for value type parameters.
- Changed structure of source code project to use a Shared Project instead of having the Runtime project link all the files in the Editor project.

// UltEvents v1.0 //

- Initial release.