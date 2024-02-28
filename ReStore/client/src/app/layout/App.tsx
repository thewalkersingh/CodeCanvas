import { useEffect, useState } from "react";
import { Product } from "../models/product";
import Catalog from "../../features/catalog/Catalog";
import { Typography } from "@mui/material";

function App() {
  const [products, setProducts] = useState<Product[]>([]);
  useEffect(() => {
    fetch("http://localhost:5000/api/products")
      .then((response) => response.json())
      .then((data) => setProducts(data));
  }, []);
  function addProducts() {
    setProducts((prevState) => [
      ...products,
      {
        id: prevState.length + 101,
        name: "product " + (prevState.length + 1),
        price: prevState.length * 100 + 100,
        brand: "some brand",
        description: "some description",
        pictureUrl: "http://picsum.photos/104",
      },
    ]);
  }
  return (
    <div className="app">
      <Typography variant="h4">Re-Store</Typography>
      <Catalog products={products} addProduct={addProducts} />
    </div>
  );
}
export default App;
