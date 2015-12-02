//Do not forget to add Squirrel namespace!
using Squirrel;

using (var mgr = new UpdateManager("https://path/to/my/update/folder"))
{
    await mgr.UpdateApp();
}
