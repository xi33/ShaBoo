var arrItems1 = new Array();
	var arrItemsGrp1 = new Array();

	arrItems1[3] = "��ҵѧԺ";
	arrItemsGrp1[3] = 1;
	arrItems1[4] = "��ȫѧԺ";
	arrItemsGrp1[4] = 1;
	arrItems1[5] = "����ѧԺ";
	arrItemsGrp1[5] = 1;
	
	arrItems1[6] = "����ѧԺ";
	arrItemsGrp1[6] = 1;
	arrItems1[7] = "�ŵ�ѧԺ";
	arrItemsGrp1[7] = 1;
	arrItems1[8] = "��ԴѧԺ";
	arrItemsGrp1[8] = 1;
	
	arrItems1[9] = "����ѧԺ";
	arrItemsGrp1[9] = 1;
	arrItems1[10] = "����ѧԺ";
	arrItemsGrp1[10] = 1;
	arrItems1[11] = "����ѧԺ";
	arrItemsGrp1[11] = 1;
	
	arrItems1[12] = "����ѧԺ";
	arrItemsGrp1[12] = 1;
	arrItems1[13] = "�ķ�ѧԺ";
	arrItemsGrp1[13] = 1;
	arrItems1[14] = "��ѧԺ";
	arrItemsGrp1[14] = 1;
	
	arrItems1[15] = "�����ѧԺ";
	arrItemsGrp1[15] = 1;
	arrItems1[16] = "���˼����ѧԺ";
	arrItemsGrp1[16] = 1;
	
	arrItems1[17] = "����ѧԺ";
	arrItemsGrp1[17] = 1;
	arrItems1[18] = "����ѧԺ";
	arrItemsGrp1[18] = 1;
	arrItems1[19] = "����ѧԺ";
	arrItemsGrp1[19] = 1;
	
	
	arrItems1[20] = "����ѧԺ";
	arrItemsGrp1[20] = 1;
	arrItems1[21] = "��Խ��ѧԺ";
	arrItemsGrp1[21] = 1;
	arrItems1[22] = "����ѧԺ";
	arrItemsGrp1[22] = 1;
	arrItems1[23] = "Ӧ��ѧԺ";
	arrItemsGrp1[23] = 1;
	arrItems1[24] = "�ɽ�ѧԺ";
	arrItemsGrp1[24] = 1;
	
	arrItems1[25] = "PPTģ��";
	arrItemsGrp1[25] = 2;
	arrItems1[26] = "�����̳�";
	arrItemsGrp1[26] = 2;
	arrItems1[27] = "IT��������";
	arrItemsGrp1[27] = 2;
	
	arrItems1[0] = "�ĸ�����";
	arrItemsGrp1[0] = 3;
	arrItems1[1] = "��Ϸ����";
	arrItemsGrp1[1] = 3;
	arrItems1[2] = "Ц������";
	arrItemsGrp1[2] = 3;
	
	arrItems1[28] = "��ѡ��";
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
	myEle.text = "��ѡ��" ;
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