public class Logger {

    private Dictionary<string, int> msgToTimestamp;

    public Logger() {
        msgToTimestamp = new Dictionary<string, int>();
    }
    
    public bool ShouldPrintMessage(int timestamp, string message) {
        
        bool printMessage = true;

        if (msgToTimestamp.TryGetValue(message, out var prevTimestamp)) {
            printMessage = timestamp - prevTimestamp >= 10;
        }

        if (printMessage) msgToTimestamp[message] = timestamp;
        
        return printMessage;
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
 */
