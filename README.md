# P3P De-Duplicator
A mod for P3P PC that removes the use of some duplicate files to make it easier for mods to replace them.

## Usage
If your mod needs to make use of this all you need to do is add a dependency on it. 
To do so you will need to first download it, either directly from Reloaded (search for "De-Duplicator") or by manually downloading the [latest release](https://github.com/AnimatedSwine37/p3ppc.deDuplicator/releases/latest). 

## Affected Files
Following is a list of all types of duplicate files that are removed by this mod. 
If you know of other duplicate files that are making it difficult to make mods reach out to me and maybe I can add support.

### Bustup Bst Bins
Some events load bustups from `bstxxx.bin` files which contain duplicates of the individual bustup bins. 
These are no longer used, all bustups are now loaded individually from their `bxx_yy-z.bin` files.