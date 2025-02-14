public class ProductOfNumbers {
    private List<int> prefixProduct;
    public ProductOfNumbers() {
        prefixProduct = new List<int>();
        prefixProduct.Add(1);
    }
    
    public void Add(int num) {
        if (num == 0) {
            prefixProduct.Clear();
            prefixProduct.Add(1); 
        } else {
            int lastProduct = prefixProduct[prefixProduct.Count - 1];
            prefixProduct.Add(lastProduct * num);
        }
    }
    
    public int GetProduct(int k) {
        int n = prefixProduct.Count;
        if (k >= n) {
            return 0; 
        }
        return prefixProduct[n - 1] / prefixProduct[n - k - 1];
    }
}

/**
 * Your ProductOfNumbers object will be instantiated and called as such:
 * ProductOfNumbers obj = new ProductOfNumbers();
 * obj.Add(num);
 * int param_2 = obj.GetProduct(k);
 */