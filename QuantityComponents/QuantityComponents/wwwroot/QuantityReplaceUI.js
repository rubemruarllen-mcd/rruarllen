﻿function ReplaceUIbyQuantity(toRepalce) {
    console.log("new UI insertion made by QuantityComponents")
    for (var index = 0; index < toRepalce.componentParameters.length; index++) {
        var currentComponent = toRepalce.componentParameters[index];
        var currentButton = document.querySelector('[uuid="' + currentComponent.toReplace.idObjectToReplace + '"]');
        var newButton = document.getElementById(currentComponent.toReplace.idNewObject);
        currentButton.prepend(newButton);
    }
}

async function GetRequest(url) {
    return await fetch(url)
        .then((response) => response.text())
        .then(data => {
            return data;
        })
        .catch(error => {
            console.error(error);
        });
}