// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ajaxCall() {

    var e = document.getElementById("selcat");
    var strUser = e.options[e.selectedIndex].value;
    var data = {
        "CategoryName": strUser
    };
    var url = "/POS/DropDownVal"
    $.ajax({
        type: "POST",
        url: url,
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (result) {
            var productsList = $('#selprd');
            productsList.empty();

            for (var i = 0; i < result.length; i++) {
                $('#selprd').append($('<option>', {
                    value: result[i].productName,
                    text: result[i].productName
                }));
                var prd2 = $('#prdamount');
                prd2.empty();
            }

            textbox();


        }
    });
}

function textbox() {
    var prdamt = document.getElementById("selprd")
    var prd = prdamt.options[prdamt.selectedIndex].value;
    var data = {
        "CategoryName": prd
    };
    var url = "/POS/DropDownVal1"
    $.ajax({
        type: "POST",
        url: url,
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (result) {
            var prd2 = $('#prdamount');
            prd2.empty();

            for (var i = 0; i < result.length; i++) {
                $("#prdamount").append($('<span>', {
                    text: result[i].amount
                }));

            }
        }
    })
}

var count = 0;

function possaver() {
    debugger
    var prdamt = document.getElementById("selprd")
    var prd = prdamt.options[prdamt.selectedIndex].value;
    var qty = document.getElementById("quantity").value;
    var amt = document.getElementById("prdamount").innerText;
    

    if (count < 1) {
        var total = qty * amt;
        var cart = $('#carttotal');
        cart.empty();
        cart.append($('<span>', {
            text: total,
           

        }));
        transactionIDGenerator()
    }
    if (count > 1) {
        var cart = document.getElementById('carttotal').innerText;
        var total = qty * amt;
        var total = total + parseFloat(cart);
        var cart1 = $('#carttotal');
        cart1.empty();
        cart1.append($('<span>', {
            text: total,
        }));
        
    }
    count = count + 2
    
    var data = {
        "ProductName": prd,
        "Quantity": qty,
        "Amount": amt
    };
    var url = "/POS/Saver"
    $.ajax({
        
        type: "POST",
        url: url,
        contentType: "application/json",
        data: JSON.stringify(data),
        success: function (result) {
           
            var table = document.getElementById("mytable");
            var row = table.insertRow(0);

            // Insert new cells (<td> elements) at the 1st and 2nd position of the "new" <tr> element:
            var cell1 = row.insertCell(0);
            var cell2 = row.insertCell(1);
            var cell3 = row.insertCell(2);
            // Add some text to the new cells:
            cell1.innerHTML = result.productName;
            cell2.innerHTML = result.quantity;
            cell3.innerHTML = result.amount
                //location.reload();
               

            sdsaver();
        }
    });
   

   
  
}

function sdsaver() {
    debugger
    var prdamt = document.getElementById("selprd")
    var prd = prdamt.options[prdamt.selectedIndex].value;
    var qty = document.getElementById("quantity").value;
    var amt = document.getElementById("prdamount").innerText;
    var transactionID = document.getElementById("transactionid").innerText;

    var data = {
        "TransactionID": transactionID,
        "ProductName": prd,
        "Quantity": qty,
        "Amount": amt
    };
    var url = "/POS/SdSaver"
    $.ajax({
        type: "POST",
        url: url,
        contentType: "application/json",
        data: JSON.stringify(data)

    })
    var prd2 = $('#prdamount');
    prd2.empty();
   
}

function transactionIDGenerator() {
    var transId = $('#transactionid');
    var td = Math.random();
    transId.empty();
    transId.append($('<span>', {
        text: td,
    }));
}

function print() {
    debugger
    var transactionID = document.getElementById("transactionid").innerText;
    var date = document.getElementById("date").value;
    var customername = document.getElementById("selcust")
    var selectedcustomer = customername.options[customername.selectedIndex].text;
    var carttotal = document.getElementById('carttotal').innerText;
    var amountpaid = document.getElementById('amountpaid').value;
    var balance = carttotal - amountpaid;
    var data = {
        "TransactionID": transactionID,
        "Date": date,
        "CustomerName": selectedcustomer,
        "TotalAmount": carttotal,
        "Amountpaid": amountpaid,
        "Balance": balance
    }
    var url = "/POS/Printer"
    $.ajax({
        type: "POST",
        url: url,
        contentType: "application/json",
        data: JSON.stringify(data)

    })

}

