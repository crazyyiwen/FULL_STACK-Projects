// JavaScript Document
/*
 * Yiwen Zhao
 * Training assignment_1
 * jquery + javascript
 * script.js
 */
$(document).ready(function(){

    // debugger;
    $.getJSON("jqd.json", function(data){

    // set variables to get all the data
    var j = 0;
    var KEY = new Array()
    var VALUE = new Array();
    var student = '';
    var click_counter = 0;
    //var stu_obj;

    // get data from value(iteration)
    $.each(data, function(key, value){
        // use localStorage to store the data
        KEY.push(key);
        VALUE.push(value);

    });

    localStorage.setItem("stu_key", JSON.stringify(KEY));
    localStorage.setItem("stu_value", JSON.stringify(VALUE));
    var stukey_all = JSON.parse(localStorage.getItem("stu_key"));
    var stuvalue_all = JSON.parse(localStorage.getItem("stu_value"));

    //-----------------------------Search------------------------------
    
    $("#myInput").keypress(function(e) {
      
        var keycode = (event.keyCode ? event.keyCode : event.which);
        if(keycode == '13'){
            var stu_para = $('#myInput').val().toLowerCase();
            //alert(stuvalue_all[1].firstname);
            
            $("#student_table").find("tr:gt(0)").remove();
            student = '';
            for(i=0; i<stukey_all.length;i++){
                if((stu_para == stuvalue_all[i].firstname.toLowerCase()) || (stu_para == stuvalue_all[i].lastname.toLowerCase())
                   || (stu_para == stuvalue_all[i].email.toLowerCase()) || (stu_para == stuvalue_all[i].phone.toLowerCase())){
                    student += '<tr>';
                    student += '<td>' + i + '</td>';
                    student += '<td>' + stuvalue_all[i].firstname + '</td>';
                    student += '<td>' + stuvalue_all[i].lastname + '</td>';
                    student += '<td>' + stuvalue_all[i].email + '</td>';
                    student += '<td>' + stuvalue_all[i].location + '</td>';
                    student += '<td>' + stuvalue_all[i].phone + '</td>';
                    student += '<td>' + stuvalue_all[i].address.communication + "  " + stuvalue_all[i].address.permanent + '</td>';
                    student += '<td>' + stuvalue_all[i].marks.english + "  " + stuvalue_all[i].marks.science + "  " + stuvalue_all[i].marks.computers + 
                    "  " + stuvalue_all[i].marks.computers + "  " + '</td>';
                }
                else{
                  ;
                }
            }
            $('#student_table').append(student);
        }  
    });

    //---------------------------Add element---------------------------
    $("#add").click(function(){
        
        $("#insert_table").show(); 
        // bind click
        $("#Asubmit").bind("click");
        $("#Asubmit").click(function(){
            var L1 = $('#input_fname').val();
            var L2 = $('#input_lname').val();
            var L3 = $('#input_email').val();
            var L4 = $('#input_phone').val();
            var stu_obj = {"firstname":L1,
                           "lastname":L2,
                           "email":L3,
                           "location":["Piscataway","Newyork","California"],
                           "phone":L4,
                           "address":{"communication":"Itlize, Piscataway, New Jersey","permanent":"Zhejiang, China"},
                           "marks":{"english":"70","science":"80","computers":"90","hardware":"80"}};

            var count = stukey_all.length + 1; 
            KEY.push(count);   
            VALUE.push(stu_obj);
            
            // update the local data
            localStorage.setItem("stu_key", JSON.stringify(KEY));
            localStorage.setItem("stu_value", JSON.stringify(VALUE));
            stukey_all = JSON.parse(localStorage.getItem("stu_key"));
            stuvalue_all = JSON.parse(localStorage.getItem("stu_value"));
             
            $("#insert_table").hide();
            // this unbind is very important, otherwise multiple click will happen
            $("#Asubmit").unbind("click");
        });       
    });
    //------------------Delete data fron json file----------------------
    $("#del").click(function(){
        
        $("#insert_table").show();
        // bind click
        $("#Dsubmit").bind("click");
        $("#Dsubmit").click(function(){
            var L1 = $('#input_fname').val();
            var L2 = $('#input_lname').val();
            var L3 = $('#input_email').val();
            var L4 = $('#input_phone').val();
            //alert(stukey_all.length);
            for(i=0; i<stukey_all.length;i++){
                if((L1.toLowerCase === stuvalue_all[i].firstname.toLowerCase()) || (L2.toLowerCase === stuvalue_all[i].lastname.toLowerCase())
                   || (L3.toLowerCase === stuvalue_all[i].email.toLowerCase()) || (L4.toLowerCase === stuvalue_all[i].phone.toLowerCase())){
                    //delete VALUE[i];
                    // localStorage.setItem("stu_key", JSON.stringify(KEY));
                    // localStorage.setItem("stu_value", JSON.stringify(VALUE));
                    // stukey_all = JSON.parse(localStorage.getItem("stu_key"));
                    // stuvalue_all = JSON.parse(localStorage.getItem("stu_value"));
                    alert(2);
                }
                else{
                
                }
            } 
            $("#insert_table").hide();
            // this unbind is very important, otherwise multiple click will happen
            $("#Dsubmit").unbind("click");   
        });   
    });
    //-------------------------------------------------------------------
    // click 20 rows
    $("#20t, #20b").click(function(){
        $("#student_table").find("tr:gt(0)").remove();
        // student must be emptied
        student = '';
        localStorage.setItem("stu_key", JSON.stringify(KEY));
        localStorage.setItem("stu_value", JSON.stringify(VALUE));

        stukey_all = JSON.parse(localStorage.getItem("stu_key"));
        stuvalue_all = JSON.parse(localStorage.getItem("stu_value"));
        for(i=0; i<20; i++){
            // retrive the data
            student += '<tr>';
            student += '<td>' + i + '</td>';
            student += '<td>' + stuvalue_all[i].firstname + '</td>';
            student += '<td>' + stuvalue_all[i].lastname + '</td>';
            student += '<td>' + stuvalue_all[i].email + '</td>';
            student += '<td>' + stuvalue_all[i].location + '</td>';
            student += '<td>' + stuvalue_all[i].phone + '</td>';
            student += '<td>' + stuvalue_all[i].address.communication + "  " + stuvalue_all[i].address.permanent + '</td>';
            student += '<td>' + stuvalue_all[i].marks.english + "  " + stuvalue_all[i].marks.science + "  " + stuvalue_all[i].marks.computers + 
            "  " + stuvalue_all[i].marks.computers + "  " + '</td>';
        }
            
        $('#student_table').append(student);
    });

    // click 50 rows
    $("#50t, #50b").click(function(){
        $("#student_table").find("tr:gt(0)").remove();
        // student must be emptied
        student = '';
        localStorage.setItem("stu_key", JSON.stringify(KEY));
        localStorage.setItem("stu_value", JSON.stringify(VALUE));

        stukey_all = JSON.parse(localStorage.getItem("stu_key"));
        stuvalue_all = JSON.parse(localStorage.getItem("stu_value"));
        for(i=0; i<50; i++){
            // retrive the data
            student += '<tr>';
            student += '<td>' + i + '</td>';
            student += '<td>' + stuvalue_all[i].firstname + '</td>';
            student += '<td>' + stuvalue_all[i].lastname + '</td>';
            student += '<td>' + stuvalue_all[i].email + '</td>';
            student += '<td>' + stuvalue_all[i].location + '</td>';
            student += '<td>' + stuvalue_all[i].phone + '</td>';
            student += '<td>' + stuvalue_all[i].address.communication + "  " + stuvalue_all[i].address.permanent + '</td>';
            student += '<td>' + stuvalue_all[i].marks.english + "  " + stuvalue_all[i].marks.science + "  " + stuvalue_all[i].marks.computers + 
            "  " + stuvalue_all[i].marks.computers + "  " + '</td>';
        }
        $('#student_table').append(student);  
    });

    // click 100 rows
    $("#100t, #100b").click(function(){
        $("#student_table").find("tr:gt(0)").remove();
        // student must be emptied
        student = '';
        localStorage.setItem("stu_key", JSON.stringify(KEY));
        localStorage.setItem("stu_value", JSON.stringify(VALUE));

        stukey_all = JSON.parse(localStorage.getItem("stu_key"));
        stuvalue_all = JSON.parse(localStorage.getItem("stu_value"));
        for(i=0; i<100; i++){
            // retrive the data 
            student += '<tr>';
            student += '<td>' + i + '</td>';
            student += '<td>' + stuvalue_all[i].firstname + '</td>';
            student += '<td>' + stuvalue_all[i].lastname + '</td>';
            student += '<td>' + stuvalue_all[i].email + '</td>';
            student += '<td>' + stuvalue_all[i].location + '</td>';
            student += '<td>' + stuvalue_all[i].phone + '</td>';
            student += '<td>' + stuvalue_all[i].address.communication + "  " + stuvalue_all[i].address.permanent + '</td>';
            student += '<td>' + stuvalue_all[i].marks.english + "  " + stuvalue_all[i].marks.science + "  " + stuvalue_all[i].marks.computers + 
            "  " + stuvalue_all[i].marks.computers + "  " + '</td>';
        }
        $('#student_table').append(student);
    });

    // click all rows
    $("#allt, #allb").click(function(){
        $("#student_table").find("tr:gt(0)").remove();
        // student must be emptied
        student = '';
        localStorage.setItem("stu_key", JSON.stringify(KEY));
        localStorage.setItem("stu_value", JSON.stringify(VALUE));

        stukey_all = JSON.parse(localStorage.getItem("stu_key"));
        stuvalue_all = JSON.parse(localStorage.getItem("stu_value"));
        for(i=0; i<stukey_all.length; i++){
            // retrive the data
            student += '<tr>';
            student += '<td>' + i + '</td>';
            student += '<td>' + stuvalue_all[i].firstname + '</td>';
            student += '<td>' + stuvalue_all[i].lastname + '</td>';
            student += '<td>' + stuvalue_all[i].email + '</td>';
            student += '<td>' + stuvalue_all[i].location + '</td>';
            student += '<td>' + stuvalue_all[i].phone + '</td>';
            student += '<td>' + stuvalue_all[i].address.communication + "  " + stuvalue_all[i].address.permanent + '</td>';
            student += '<td>' + stuvalue_all[i].marks.english + "  " + stuvalue_all[i].marks.science + "  " + stuvalue_all[i].marks.computers + 
            "  " + stuvalue_all[i].marks.computers + "  " + '</td>';
        }
        $('#student_table').append(student);
      });
  }); 
}); 

