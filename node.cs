class Node {
    private char value;
    private Node next = null;

    public Node(char value) {
        this.value = value;
    }

    public void SetNext(Node next) {
        this.next = next;
    }

    public Node Next() {
        return this.next;
    }

    public char GetValue() {
        return this.value;
    }
}