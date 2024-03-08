## Tracing and Logging

## Why logging?

Due to the longer term and increasing of complexity

- Issues that occur over long periods of time can be difficult to debug with a traditional debugger. Logs allow for detailed post-mortem review that spans long periods of time. In contrast, debuggers are constrained to real-time analysis.
- Multi-threaded applications and distributed applications are often difficult to debug. Attaching a debugger tends to modify behaviors. You can analyze detailed logs as needed to understand complex systems.
- Issues in distributed applications might arise from a complex interaction between many components. It might not be reasonable to connect a debugger to every part of the system.
- Many services shouldn't be stalled. Attaching a debugger often causes timeout failures.
- Issues aren't always foreseen. Logging and tracing are designed for low overhead so that programs can always be recording in case an issue occurs.

## Print System API

- System.Console
  - Always enabled and always writes to the console.
  - Useful for information that your customer might need to see in the release.
  - Because it's the simplest approach, it's often used for ad-hoc temporary debugging. This debug code is often never checked in to source control.
- System.Diagnostics.Trace
  - Only enabled when TRACE is defined.
  - Writes to attached Listeners, by default, the DefaultTraceListener.
  - Use this API when you create logs that will be enabled in most builds.
- System.Diagnostics.Debug
  - Only enabled when DEBUG is defined (when in debug mode).
  - Writes to an attached debugger.
  - Use this API when you create logs that will be enabled only in debug builds.
  - Debug.Assert/Debug.Writeline message won't effect the code in produce
  - Debug.Assert is more like a conditional break point. If condition be breached, code will be paused if in debugger, and get the message in both debugger and regular running
