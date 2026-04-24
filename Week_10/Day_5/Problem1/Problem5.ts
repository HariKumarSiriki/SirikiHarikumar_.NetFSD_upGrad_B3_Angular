
function getFirstElement<T>(items: T[]): T {
  return items[0];
}



interface Repository<T> {
  add(item: T): void;
  getAll(): T[];
}


class DataManager<T> implements Repository<T> {

  private data: T[] = [];

  add(item: T): void {
    this.data.push(item);
  }

  getAll(): T[] {
    return this.data;
  }
}


interface User {
  id: number;
  name: string;
}

interface Product {
  id: number;
  title: string;
}

let userManager = new DataManager<User>();

userManager.add({ id: 1, name: "Hari" });
userManager.add({ id: 2, name: "Scott" });

console.log("User List:");
console.log(userManager.getAll());



let productManager = new DataManager<Product>();

productManager.add({ id: 101, title: "Laptop" });
productManager.add({ id: 102, title: "Mobile" });

console.log("Product List:");
console.log(productManager.getAll());



console.log("First User:", getFirstElement(userManager.getAll()));
console.log("First Product:", getFirstElement(productManager.getAll()));