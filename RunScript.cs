using System.Diagnostics;
public class ScriptRunner {
    public static void Run() {
        Process process = new Process();
        process.StartInfo.FileName = "wget";
        process.StartInfo.Arguments = "-r \"https://github.com/TheMarteh/dotnet-artifact-test/releases/download/latest/dotnet-artifact-test.dll\"";

        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        // start the process
        process.Start();

        // Read the output of the process
        string output = process.StandardOutput.ReadToEnd();

        // wait for the process to exit
        process.WaitForExit();

        // exit the program so systemd can restart it
        Environment.Exit(0);
    }
}