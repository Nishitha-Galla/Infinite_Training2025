## &nbsp;												***1NF***

			



		**ClientNo	cName		PropertyNo	pAddress	rentStart	rentFinish	rent	OwnerNo		oName**

		

		**CR76		John Kay	PG4		6 Lawrence St,	1-Jul-00	31-Aug-01	350	CO40		Tina Murphy**

								**Glasgow**	

		

	

		**CR76		John Kay	PG16		5 Novar Dr,	1-Sept-02	1-Sept-02	450	CO93		Tony Shaw**

								**Glasgow**



&nbsp;		

&nbsp;		**CR56		Aline Stewart	PG4		6 Lawrence St,	1-Sept-99	10-Jun-00	350	CO40		Tina Murphy**

								**Glasgow**



		

		**CR56		Aline Stewart	PG36		2 Manor Rd,	10-Oct-00	1-Dec-01	370	CO93		Tony Shaw**

&nbsp;								Glasgow


		**CR56		Aline Stewart	PG16		5 Manor Rd,	1-Nov-02	1-Aug-03	450	CO93		Tina Murphy**

 								Glasgow
		
				***2NF***
---

###### &nbsp;		***Client***

		

<b>		ClientNo	cName</b>



<b>		CR76		John Kay</b>

		

<b>		CR56		Aline Stewart</b>



###### 		

###### <b>		*Property*</b>



		

<b>		PropertyNo	pAddress		OwnerNo</b>



<b>		PG4		6 Lawrence St, Glasgow	CO40</b>

		

<b>		PG16		5 Novar Dr, Glasgow	CO93</b>



<b>		PG36		2 Manor Rd, Glasgow	CO93</b>

		

###### <b>		*Owner*</b>

		

<b>		OwnerNo		oName</b>

		

<b>		CO40		Tina Murphy</b>



<b>		CO93		Tony Shaw</b>



###### <b>		*Rent*</b>



&nbsp;		**ClientNo	PropertyNo	rentStart	rentFinish	rent**

				

		**CR76		PG4		1-Jul-00	31-Aug-01	350**

		

		**CR76		PG16		1-Sep-02	1-Sep-02	450**



		**CR56		PG36		1-Sep-99	10-Jun-00	350**



&nbsp;		**CR56		PG36		10-Oct-00	1-Dec-01	370**



		**CR56		PG16		1-Nov-02	1-Aug-03	450**













