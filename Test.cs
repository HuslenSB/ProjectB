class program {
    public static void Main() {
        int len = 5;
        int[] array = new int[len];
        int s=1;
        for(int i = 0; i<len;i++){
            if (s%2!=0){
                array[i]=s;
                s+=2;
            }
        }
        string task = "update first and last";
        array[0] = 99;
        array[len-1] = 88;
    }
}