function sameCase(str) {
    const cap = /[A-Z]/g
    const low = /[a-z]/g
    if (cap.test(str) || low.test(str)){
        return true;
    } else {
        return false;
    };
}