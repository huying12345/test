fis.hook("relative");fis.match("**",{relative:true});fis.match("app/**",{release:false});fis.set("project.ignore",["app/**","output/**","include/**",".git/**","fis-conf.js","*.bat"]);fis.match("*.scss",{rExt:".css",parser:fis.plugin("node-sass")});fis.match("/assets/js/**.js",{optimizer:fis.plugin("uglify-js",{mangle:{},compress:{drop_console:true}})});fis.match("*.css",{optimizer:fis.plugin("clean-css")});fis.match("*.png",{optimizer:fis.plugin("png-compressor")});fis.media("debug").match("*.{js,css,png}",{useHash:false,useSprite:false,optimizer:null});