package Models;

import java.util.ArrayList;
import java.util.List;

public class Customer {
    private String firstName;
    private String lastName;
    private String address;
    private String state;
    private String zip;
    private String phoneNumber;
    List<Room> rooms = new ArrayList<>();
}
