mergeInto(LibraryManager.library, {

  InitializeInternal: function () {
    window.script = document.createElement('script');
    window.script.type="text/javascript";
    window.script.src="https://code.jquery.com/jquery-3.6.0.min.js";
    document.body.appendChild(window.script);
    window.container = document.getElementById("unityContainer");
    window.iframe = document.createElement('iframe');
    window.iframe.loading="lazy";
    window.iframe.referrerpolicy="strict-origin";
    window.iframe.style = "height: 100%; width: 100%; z-index: 2; position: absolute; left: 0px; top: 0px;";
    window.container.appendChild(window.iframe);
    window.innerDocument = window.iframe.contentDocument || window.iframe.contentWindow.document;
  },

  SetPassthroughInternal: function () {
    window.iframe.style["pointer-events"]="none";
    window.iframe.style["user-select"]="none";
  },

  SetDataInternal: function (str) {
    window.iframe.src = 'data:text/html;charset=utf-8,' + encodeURI(Pointer_stringify(str));
  },

  SetURLInternal: function (str) {
    window.iframe.src = Pointer_stringify(str);
  },

});