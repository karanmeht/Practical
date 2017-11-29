function ConfirmationOnDelete() {
    var confirmation = confirm("Are you sure want to delete this record");
    if (confirmation) {
        return true;
    }
    return flase;
}