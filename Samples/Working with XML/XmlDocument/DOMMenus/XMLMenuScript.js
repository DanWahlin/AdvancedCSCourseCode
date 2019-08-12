var currentSpanElement		= "";			//Needed to track current span element
var menuArray				= new Array();	//Tracks what divs are showing so it knows what to hide when a new span is clicked
var onTextColor				= "#FFFFFF";	//Text color with mouseover
var offTextColor			= "#000000";	//Text color with NO mouseover
var onCellColor				= "#A61616";	//Span color with mouseover
var offCellColor			= "#EEEEE6";	//Span color with nomouseover
var offsetMenuX				= 110;			//X Distance new menu will be from parent menu
var offsetMenuY				= 5;			//Y Distance increase of new menu compared to parent span
var startDistanceX			= -10;			//Sets how far off onMouseOver start element we should go
var startDistanceY			= 5;			//Sets how far off onMouseOver start element we should go
var menuOn					= false;		//Only one set of menus can be displayed at once
var started					= false;		//Used to track if we just started the menus
var clickStart				= true;			//Allow an onClick event to start the menu or not here
var clickX					= 0;			//Location X of event to start menu
var clickY					= 0;			//Location Y of event to start menu
var selectCount				= 0;
var select					= "";
var appletCount				= 0;			//If we have applets, track the # so we can temporarily hide them
var applets					= "";			//Tracks the document.all.tags("applet") collection so we can reference it once rather than twice

function startIt(menu,thisItem,level) {						//menu = menu to display,thisItem=coordinates of item to use,level=current depth of menus
	if (menuOn == true) {
		window.event.cancelBubble = true;
		hideAllDivs();
		return;												//Only allow one menu to be activated at a time
	} else {
		select = document.all.tags("select");
		selectCount = select.length;
		if (selectCount > 0) {
			for (i=0;i<selectCount;i++) {
				select.item(i).style.visibility = "hidden";
			}
		}
		applets = document.all.tags("applet");
		appletCount = applets.length;
		if (appletCount > 0) {
			for (i=0;i<appletCount;i++) {
				applets.item(i).style.visibility = "hidden";
			}
		}
		menuOn = true;			
		started = true;										//Lets us know we're coming in for the 1st time
		clickX = event.clientX;
		clickY = event.clientY;
		if (clickStart) window.event.cancelBubble = true;		
		stateChange(menu,thisItem,level);
	}	
}

function stateChange(menu,thisItem,level) {									//menu = menu to display,thisItem=name of span item to use,level=current depth of menus
	
	if (currentSpanElement != thisItem.id && started != true) {							//Only hit this if they changed span elements	
		if (currentSpanElement == "") currentSpanElement = thisItem.id;	//Used 1st time through only	

		eItemOld = eval("document.all('" + currentSpanElement + "')");
		eItemNew = eval("document.all('" + thisItem.id + "')");
		eParent = eItemNew.parentElement;
		eParent.style.background = offCellColor;						//Must set DIV background color or it will be transparent by default	
			
		//Turn off whatever span was turned on
		eItemOld.style.background = offCellColor;
		eItemOld.style.color = offTextColor;
		//Turn on new span
		eItemNew.style.background = onCellColor;
		eItemNew.style.color = onTextColor;

		currentSpanElement = thisItem.id;					//Track where the last mouseover came from
	}
	
	if (menu != "") {
		eMenu = eval("document.all('" + menu + "')");			
		eItem = eval("document.all('" + thisItem.id + "')");				//Used for x,y coordinates
		hideDiv(level);
		menuArray[menuArray.length] = menu;									//Tracks open menus	

		var positionX =  eItem.parentElement.offsetLeft + offsetMenuX + document.body.scrollLeft;
		var positionY =   eItem.parentElement.offsetTop + eItem.offsetTop + offsetMenuY + document.body.scrollTop;
		if (started) {
			positionX =	clickX + startDistanceX	+ document.body.scrollLeft	//eItem.offsetLeft + startDistanceX;
			positionY =	clickY + startDistanceY	+ document.body.scrollTop	//eItem.offsetTop + startDistanceY;
		}
		//If screen isn't wide enough to fit menu, bump menu back to the left some
		if ((positionX + eMenu.offsetWidth) >= document.body.clientWidth) {
			positionX -= (eMenu.offsetWidth * 1.3);
			positionY += 15;
		}
		//If the menu is too far to the left to display, bump it to the right some
		if ((positionX + eMenu.offsetWidth) <= eMenu.offsetWidth) {
			positionX += (eMenu.offsetWidth * 1.3);
		}
		//If the menu is too far down, bump the menu up to the bottom equals the body clientHeight property
		if ((positionY + eMenu.offsetHeight) >= document.body.clientHeight) {
			if (started != true) positionY = document.body.clientHeight - eMenu.offsetHeight;
		}
	
		eMenu.style.left = positionX;
		eMenu.style.top = positionY;
		//eMenu.style.zIndex = level;									//Only use this if we don't reverse the arrays in the ASP/XML Script
		eMenu.style.display="block";
	}
	
	started = false;												//After 1st menu, turn of started variable
}

function hideDiv(currentLevel) {
		for (var i=currentLevel;i<menuArray.length;i++) {
			var arrayString = new String(menuArray[i]);
			if (arrayString == "undefined") continue;
			eval("document.all('" + menuArray[i] + "').style.display='none'");
		}
			menuArray.length = currentLevel;
}

function hideAllDivs() {
	if (menuOn == true) {		//Don't loop through document elements if they clicked a hyperlink since it wastes time
		for (var i=0;i<menuArray.length;i++) {
			var arrayString = new String(menuArray[i]);
			if (arrayString == "undefined") continue;
			document.all(menuArray[i]).style.display = "none";
			document.all(menuArray[i]).style.left = 0;
			document.all(menuArray[i]).style.top = 0;

		}
		if (currentSpanElement != "") {					//No currentSpanElement if they haven't mousedOver any span element
			eItem = eval("document.all('" + currentSpanElement + "')");
			eItem.style.background = offCellColor;		//Ensure current span's color is changed back to "off" color
			eItem.style.color = offTextColor;		//Ensure current span's text color is changed back to "off" color
			menuArray = new Array();	
			currentSpanElement = "";		
		}
		if (selectCount > 0) {
			for (i=0;i<selectCount;i++) {
				select.item(i).style.visibility = "visible";
			}
			selectCount = 0;
			select = "";
		}
		if (appletCount > 0) {
			for (i=0;i<appletCount;i++) {
				applets.item(i).style.visibility = "visible";
			}
			appletCount = 0;
			applets = "";
		}
	}
	menuOn = false;								//Menus off, so set this to false


}

document.onclick = hideAllDivs;