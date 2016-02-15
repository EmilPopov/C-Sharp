function checkIsMozillaBrowser() {
  var currentBrowserName = window.navigator.appCodeName,
      isMozilla = currentBrowserName === "Mozilla";
  if(isMozilla) {
    alert("Yes");
  } else {
    alert("No");
  }
}