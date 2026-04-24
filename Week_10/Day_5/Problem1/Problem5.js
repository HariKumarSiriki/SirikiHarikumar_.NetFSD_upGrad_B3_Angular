"use strict";
function getFirstElement(items) {
    return items[0];
}
class DataManager {
    data = [];
    add(item) {
        this.data.push(item);
    }
    getAll() {
        return this.data;
    }
}
let userManager = new DataManager();
userManager.add({ id: 1, name: "Hari" });
userManager.add({ id: 2, name: "Scott" });

console.log("User List:");
console.log(userManager.getAll());

let productManager = new DataManager();
productManager.add({ id: 101, title: "Laptop" });
productManager.add({ id: 102, title: "Mobile" });

console.log("Product List:");
console.log(productManager.getAll());

console.log("First User:", getFirstElement(userManager.getAll()));
console.log("First Product:", getFirstElement(productManager.getAll()));
