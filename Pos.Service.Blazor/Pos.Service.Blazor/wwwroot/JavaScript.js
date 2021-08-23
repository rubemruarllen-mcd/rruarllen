var DotnetRefMenu;

function SetDotnetRef(dotNetRef) {
    DotnetRefMenu = dotNetRef;
    InjectNewButtons(dotNetRef);
}


function InjectNewButtons() {
    DotnetRefMenu.invokeMethod("RenderFragments");
}

function CreateRender() {
    var base = document.createElement("base");
    base.src = "https://localhost:5001";
    document.head.appendChild(base);
    var parentDiv = document.createElement('div');
    parentDiv.setAttribute = "BLAZOR";
    var app = document.createElement('div');
    app.id = "app";
    app.innerText = "Loading...";
    var div = document.createElement('div');    parentDiv.appendChild(app);
    parentDiv.appendChild(div);
    document.body.appendChild(parentDiv);
    var blazorServerUrl = "https://localhost:5001";
    var blazorjsUrl = blazorServerUrl + "/_framework/blazor.webassembly.js";
    fetch(blazorjsUrl).then((response) => {
        if (response.ok) {
            response.text().then((content) => {
                var correctedPathPrefix = blazorServerUrl + "/_framework/";
                content = content.split('_framework/').join(correctedPathPrefix);
                var script = document.createElement("script");
                script.innerText = content;
                parentDiv.appendChild(script);
            });
        }
    });

}

