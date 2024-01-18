public class ScriptRunner {
    public static void Run() {
        Process process = new Process();
        process.StartInfo.FileName = "wget";
        process.StartInfo.Arguments = "-N 'https://github.com/TheMarteh/dotnet-artifact-test/releases/download/latest/dotnet-artifact-test.dll'";

        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        // start the process
        process.Start();
    }
}