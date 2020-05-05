
using CloudCommercePro.Constants;
using CloudCommercePro.Helper;

namespace CloudCommercePro.ConsoleApp
{
    public static class ConsoleString
    {
        // Greetings
        internal static readonly string Greeting1 = $"Good day to all at cloud commerce.";
        internal static readonly string Greeting2 = $"I hope you enjoy the CSV file reader as much as I enjoyed doing it.";
        internal static readonly string Greeting3 = $"Developed By Anthony McEvoy.";

        //Caveat message
        internal static readonly string Caveat1 = $"NOTE: caveat for this program.";
        internal static readonly string Caveat2 = $"This program has  been tested against the JSON that came with the details for building the program.";
        internal static readonly string Caveat3 = $"The CSV has been made from the sample data provided and the CSV can be viewed at...";
        internal static readonly string Caveat4 = AssemblyHelper.GetCsvPath();

        // Misc
        internal static readonly string Continue = "Any key to continue";

        internal static readonly string DevNotes1 = "Application notes:";
        internal static readonly string DevNotes2 = "The application has been built using the repository pattern.";
        internal static readonly string DevNotes3 = "Projects are decoupled by interface's. Console => Interface => Repository => Interface => Data";
        internal static readonly string DevNotes4 = "I would usually convert a data model to a view model in the repository but I have not done that here.";
        internal static readonly string DevNotes5 = "The app contains some helper projects and code that was used for creating classes from the JSON but are not used only in the test class";
        internal static readonly string DevNotes6 = "All string constants are hard coded in the app but would normally be in a resource file";

    }
}
