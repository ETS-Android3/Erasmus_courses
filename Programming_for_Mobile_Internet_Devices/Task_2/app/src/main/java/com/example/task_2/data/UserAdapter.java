package com.example.task_2.data;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import com.example.task_2.R;

import java.util.ArrayList;

public class UserAdapter extends ArrayAdapter<User> {
    public UserAdapter(@NonNull Context context, @NonNull ArrayList<User> objects) {
        super(context, 0, objects);
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        // Extract the current item from the list
        User user = getItem(position);
        // check if a resource view exists if it does not create one
        if (convertView == null) {
            convertView = LayoutInflater.from(getContext()).inflate(R.layout.layout_list_view_row_item_user, parent, false);
        }

        // retrieve items from the view
        TextView name = convertView.findViewById(R.id.userName);
        TextView city = convertView.findViewById(R.id.cityName);
        TextView postCode = convertView.findViewById(R.id.postCode);

        // assigns the information from the User object to the elements in the view
        name.setText(user.getName());
        city.setText(user.getCity().getName());
        postCode.setText(Integer.toString(user.getCity().getPostCode()));

        // Restore the finished screen display view
        return convertView;
    }
}