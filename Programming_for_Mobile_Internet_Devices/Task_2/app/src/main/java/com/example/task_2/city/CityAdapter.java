package com.example.task_2.city;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;

import com.example.task_2.R;

import java.util.ArrayList;

public class CityAdapter extends BaseAdapter {
    private Context context; // context in which the adapter will be used
    private ArrayList<City> items; // data collection in the adapter

    // Constructor for creating an object from the class by setting the variables in the class
    public CityAdapter(Context context, ArrayList<City> items) {
        this.context = context;
        this.items = items;
    }

    @Override
    public int getCount() {
        return items.size(); // return the number of elements in the array
    }

    @Override
    public Object getItem(int position) {
        return items.get(position); // returns an item from the list at the specified position
    }

    @Override
    public long getItemId(int position) {
        return position; // returns the index of the item in the list
    }

    @Override
    public View getView(int position, View convertView, ViewGroup parent) {
        // if there is no View object, fill in the layout for each item in the list
        if (convertView == null) {
            convertView = LayoutInflater.from(context).
                    inflate(R.layout.layout_list_view_row_items, parent, false);
        }

        // retrieve the current item from the display list
        City currentItem = (City) getItem(position);

        // retrieves TextView for city name and city zip code
        TextView textViewItemName = convertView.findViewById(R.id.name);
        TextView textViewItemDescription = convertView.findViewById(R.id.postCode);

        // puts the text for no city and city zip code
        textViewItemName.setText(currentItem.getName());
        textViewItemDescription.setText(Integer.toString(currentItem.getPostCode()));

        // returns View which is the view of the element in the row
        return convertView;
    }
}

