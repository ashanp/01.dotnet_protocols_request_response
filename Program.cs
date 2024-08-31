using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
Debug.WriteLine("hellooooooooooooooooooooo");
app.Run(async (HttpContext context) => {

    context.Response.StatusCode = 200;
    context.Response.Headers.Add("Content-Type","text/html");
    
    var reqPath = context.Request.Path;
    var reqmethod = context.Request.Method;
    if (reqmethod == "GET"){
        Debug.WriteLine("reqmethod:-->" + reqmethod);
        Debug.WriteLine("reqPath:-->" + reqPath);
        if(reqPath == "/user"){
            await context.Response.WriteAsync("this is the user path");
        }
        if(reqPath == "/"){
            await context.Response.WriteAsync("This is a html formated text page");
        }
    }

/*Boolean some = 1>2;

if (some){

context.Response.StatusCode = 500;
await context.Response.WriteAsync("some text for 500");
var resHeaders = context.Response.Headers;
var reqHeaders = context.Request.Headers;

foreach (var header in resHeaders){
    Debug.WriteLine("{0}:{1}", header.Key, header.Value);
}
Debug.WriteLine("dada provided by the context: {0}", context.Request.Host);

foreach (var header in reqHeaders){
    Debug.WriteLine("{0}:{1}", header.Key, header.Value);
}
Debug.WriteLine("dada provided by the context: {0}", context.Request.Host);
}else{
    context.Response.Headers["Ashan"]= "Ashan Malinda Perera";
    context.Response.StatusCode = 200;
    await context.Response.WriteAsync("all are true");
}*/

});
app.Run();
