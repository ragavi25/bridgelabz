function formValidation() {
    var UId = document.myform.UserId;
    var FName = document.myform.FirstName;
    var LName = document.myform.LastName;
    var UEmail = document.myform.Email;
    var UN = document.myform.UserName;
    var PsW = document.myform.PassWord;
    var MoblieN = document.myform.Moblie;
    var Addr = document.myform.Address;
    if (UserId_validation(UId, 5, 7)) {
        if (AllLetter(FName)) {
            if (AllLetter(LName)) {
                if (ValidateEmail(UEmail)) {
                    if (AllLetter(UN)) {
                        if (PassWordValidation(PsW, 5, 8)) {
                            if (ValidateNumber(MoblieN)) {
                                if (Alphanumaric(Addr)) {
                                    if (EmpUpdate()) {

                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
    }
    return false;

}
function UserId_validation(UId, mx, my) {
    
    var UId_len = UId.value.length;
    if (UId_len == 0 || UId_len >= my || UId_len < mx) {
        alert("User Id should not be empty / length be between " + mx + " to " + my);
        UId.focus();
        return false;
    }
    return true;
}
function PassWordValidation(PsW, mx, my) {
    var PsW_len = PsW.value.length;
    if (PsW_len== 0 || PsW_len >= my || PsW_len < mx) {
        alert("Password should not be empty / length be between " + mx + " to " + my);
        PsW.focus();
        return false;
    }
    return true;
}
function AllLetter(FName) {
    var letters = /^[A-Za-z]+$/;
    if (FName.value.match(letters)) {
        return true;
    }        else {
        alert('Firstname must have alphabet characters only');
        FName.focus();
            return false;
        }
    
}
function Alphanumaric(Addr) {
    var letters = /^[0-9a-zA-Z]+$/;
    if (Addr.value.match(letters)) {
        return true;
    } else {
        alert('Address must have  numbers and character only');
        Addr.focus();
        return false;
    }
}
function EmpUpdate() {
    if (UserId_validation(UId, mx, my) == true && PassWordValidation(PsW, mx, my) == true && AllLetter(FName) == true && Alphanumaric(Addr) == true)
        alert('Successfully Upataded');
    else {
        alert('not correct check your detatils');
    }
}







