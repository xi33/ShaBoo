//文档站 common javascript


function addLoadEvent(func){
	var oldonload=window.onload;
	if(typeof window.onload!="function"){
		window.onload=func;
	}else{
		window.onload=function(){
			oldonload();
			func();
		}
	}
}//等价于$();由于window.onload只加载最后一个方法
function addEvent(oTarget, sEventType, fnHandler) {
    if (oTarget.addEventListener) {
        oTarget.addEventListener(sEventType, fnHandler, false);
    } else if (oTarget.attachEvent) {
        oTarget.attachEvent("on" + sEventType, fnHandler);
    } else {
        oTarget["on" + sEventType] = fnHandler;
    }
}

function test(){
	var searchText =document.getElementById("search_text")
	
function clearValue(obj)
{if(obj.value==obj.defaultValue)
obj.value="";
	}
function restoreValue(obj){
	if(obj.value=="")	
	obj.value=obj.defaultValue
		}
		addEvent(searchText,"focus",function(){clearValue(searchText);})
		addEvent(searchText,"blur",function(){restoreValue(searchText);})
}
addLoadEvent(test);

//右边用户排行的切换


$(document).ready(
	function rankchange(){ 
		$("#weeklink").mouseover(function(){
			$("#monthlink").attr("class","");
			$("#totallink").attr("class","");
			$("#weeklink").attr("class","active"); 
			$("#rmonth").attr("class","no-display");
			$("#rtotal").attr("class","no-display");
			$("#rweek").attr("class","");
			}
		);
		$("#monthlink").mouseover(function(){
			$("#weeklink").attr("class","");
			$("#totallink").attr("class","");
			$("#monthlink").attr("class","active"); 
			$("#rweek").attr("class","no-display");
			$("#rtotal").attr("class","no-display");
			$("#rmonth").attr("class","");
			}
		);
		$("#totallink").mouseover(function(){
			$("#monthlink").attr("class","");
			$("#weeklink").attr("class","");
			$("#totallink").attr("class","active"); 
			$("#rmonth").attr("class","no-display");
			$("#rweek").attr("class","no-display");
			$("#rtotal").attr("class","");
			}
		);
	}
);

