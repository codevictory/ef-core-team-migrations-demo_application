# Demo solution for EF Core migrations in team environment - Application
Application part of tutorial how to use EF Core migrations in team of multiple developers.

## Structure
The Model directory is a submodule in this repository. It contains all the needed model configuration for the EF Core and thus is separated from the rest of the version control.

## Benefits
Since in teams developers are working simultaneously in separated branches, if EF Core migration is created in more than one branch they will end up conflicting each other. This is firstly something that needs to get fixed and secondly something very time consuming and annoying to fix. Since the submodule separates the data model code from the rest of the solution those kind of conflicts are easier to handle and rarer to happen.
