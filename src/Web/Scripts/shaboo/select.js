var arrItems1 = new Array();
	var arrItemsGrp1 = new Array();

	arrItems1[3] = "矿业学院";
	arrItemsGrp1[3] = 1;
	arrItems1[4] = "安全学院";
	arrItemsGrp1[4] = 1;
	arrItems1[5] = "力建学院";
	arrItemsGrp1[5] = 1;
	
	arrItems1[6] = "机电学院";
	arrItemsGrp1[6] = 1;
	arrItems1[7] = "信电学院";
	arrItemsGrp1[7] = 1;
	arrItems1[8] = "资源学院";
	arrItemsGrp1[8] = 1;
	
	arrItems1[9] = "化工学院";
	arrItemsGrp1[9] = 1;
	arrItems1[10] = "管理学院";
	arrItemsGrp1[10] = 1;
	arrItems1[11] = "环测学院";
	arrItemsGrp1[11] = 1;
	
	arrItems1[12] = "电力学院";
	arrItemsGrp1[12] = 1;
	arrItems1[13] = "文法学院";
	arrItemsGrp1[13] = 1;
	arrItems1[14] = "理学院";
	arrItemsGrp1[14] = 1;
	
	arrItems1[15] = "计算机学院";
	arrItemsGrp1[15] = 1;
	arrItems1[16] = "马克思主义学院";
	arrItemsGrp1[16] = 1;
	
	arrItems1[17] = "材料学院";
	arrItemsGrp1[17] = 1;
	arrItems1[18] = "外文学院";
	arrItemsGrp1[18] = 1;
	arrItems1[19] = "体育学院";
	arrItemsGrp1[19] = 1;
	
	
	arrItems1[20] = "艺术学院";
	arrItemsGrp1[20] = 1;
	arrItems1[21] = "孙越崎学院";
	arrItemsGrp1[21] = 1;
	arrItems1[22] = "国际学院";
	arrItemsGrp1[22] = 1;
	arrItems1[23] = "应用学院";
	arrItemsGrp1[23] = 1;
	arrItems1[24] = "成教学院";
	arrItemsGrp1[24] = 1;
	
	arrItems1[25] = "PPT模板";
	arrItemsGrp1[25] = 2;
	arrItems1[26] = "上网教程";
	arrItemsGrp1[26] = 2;
	arrItems1[27] = "IT技巧入门";
	arrItemsGrp1[27] = 2;
	
	arrItems1[0] = "四格漫画";
	arrItemsGrp1[0] = 3;
	arrItems1[1] = "游戏攻略";
	arrItemsGrp1[1] = 3;
	arrItems1[2] = "笑话锦囊";
	arrItemsGrp1[2] = 3;
	
	arrItems1[28] = "请选择";
	function selectChange(control, controlToPopulate, ItemArray, GroupArray)
	{
		var myEle ;
		var x=28 ;
  		// Empty the second drop down box of any choices
		for (var q=controlToPopulate.options.length;q>=0;q--) controlToPopulate.options[q]=null;
    	if (control.name == "firstChoice") {
    	// Empty the third drop down box of any choices
    	//for (var q=myChoices.thirdChoice.options.length;q>=0;q--) myChoices.thirdChoice.options[q] = null;
    }
  	// ADD Default Choice - in case there are no values
    myEle = document.createElement("option") ;
    myEle.value = ItemArray[x] ;
	myEle.text = "请选择" ;
	controlToPopulate.add(myEle) ;
	for ( x = 0 ; x < ItemArray.length  ; x++ )
    {
    	if ( GroupArray[x] == control.value )
        {
        	myEle = document.createElement("option") ;
        	myEle.value = ItemArray[x] ;
        	myEle.text = ItemArray[x] ;
        	controlToPopulate.add(myEle) ;
        }
    }
	}