package com.example.task_2;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import com.example.task_2.data.User;
import com.example.task_2.data.UserAdapter;
import com.example.task_2.data.UserSource;
import com.example.task_2.helpers.Helpers;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import java.util.ArrayList;

public class MainActivity4 extends AppCompatActivity {
    private static final String TAG = "MainActivity4";
    Bundle appBundle = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main4);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);
        appBundle = getIntent().getExtras();

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent customIntent = new Intent(MainActivity4.this, MainActivity5.class);
                customIntent.putExtras(appBundle);
                startActivity(customIntent);
            }
        });

        // Create a collection with users
        ArrayList<User> arrayOfUsers = UserSource.generateItemsList();
        // Create an adapter
        UserAdapter adapter = new UserAdapter(this, arrayOfUsers);
        // Insert an adapter for ListView
        ListView listView = findViewById(R.id.listViewUsers);
        listView.setAdapter(adapter);

        listView.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
//                parent.getAdapter().getItem(position);
//                appBundle.putSerializable("user", (User)parent.getAdapter().getItem(position));
//                appBundle.putString("ratingName", (String)parent.getAdapter().getItem(position));
                Log.i(TAG, Helpers.bundle2string(appBundle));
            }
        });
    }
}