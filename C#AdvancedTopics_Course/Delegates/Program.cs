
using Delegates;

PhotoProcessor photoProcessor = new PhotoProcessor();
PhotoFilters filters = new PhotoFilters();

Action<Photo> filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += RemoveRedEyeFilter;

photoProcessor.Process("path", filterHandler);


// eigene Methode, die nicht in "Filter"-Framework vorgesehen ist
// soll aufgerufen werden 
static void RemoveRedEyeFilter(Photo photo)
{
    Console.WriteLine("Remove Red Eye");
}

