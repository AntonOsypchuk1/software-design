

using System.Net.Mime;
using Task3;

string fullpath = Path.GetFullPath("../../../example.txt");

// Proxy with logging
var loggerProxy = new SmartTextChecker();
var text = loggerProxy.ReadTextFile(fullpath);

// Proxy with access control
var accessControlProxy = new SmartTextReaderLocker(@".*\.txt");
var text2 = accessControlProxy.ReadTextFile(fullpath);
var text3 = accessControlProxy.ReadTextFile(@"example.jpg");