$('#myForm').submit(function (e) {
    e.preventDefault();
    var data = $("#myForm").serialize();

    var isValid = true;
    $('.form-control').each(function () {
        var element = $(this);
        if (element.val() == "") {
            isValid = false;
        }
    });
    $.ajax({
        type: "POST",
        url: "/ContactUs/ContactUsPost",
        data: data,
        success: function (response) {
            if (!response.success === true && isValid) {
                toastr.success('Sign Up Successful');
                $('#myForm')[0].reset();
            }
        }
    })
});

function empty() {
    var x, y, z;
    x = document.getElementById("name").value;
    y = document.getElementById("email").value;
    z = document.getElementById("message").value;
    if ((x == "" || x == null) || (y == "" || y == null) || (z == "" || z == null)) {
        if ((x == "" || x == null) && (y == "" || y == null) && (z == "" || z == null)) {
            toastr.error("All three field must be filled ");
            return false;
        }
        else if ((y == "" || y == null) && (z == "" || z == null)) {
            toastr.error("Email and Message must be filled");
            return false;
        }
        else if ((x == "" || x == null) && (y == "" || y == null)) {
            toastr.error("Name and Email must be filled");
            return false;
        }
        else if ((x == "" || x == null) && (z == "" || z == null)) {
            toastr.error("Name and Message must be filled");
            return false;
        }
        else if ((x == "" || x == null)) {
            toastr.error("Name field must be filled ");
            return false;
        }
        else if ((y == "" || y == null)) {
            toastr.error("Email field must be filled ");
            return false;
        }
        else if ((z == "" || z == null)) {
            toastr.error("Message field must be filled ");
            return false;
        }
    }
    else {
        return true;
    };
}