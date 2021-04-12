package com.example.task_1_1;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class AnotherActivity extends AppCompatActivity {
    TextView textViewFirstNameView = null;
    TextView textViewLastNameView = null;
    TextView textViewFacultyNumberView = null;
    TextView textViewSpecialtyView = null;
    View view = null;

    private void putValuesToFields(String firstName, String  lastName, String  facultyNumber, String specialty){
        textViewFirstNameView.setText(firstName);
        textViewLastNameView.setText(lastName);
        textViewFacultyNumberView.setText(facultyNumber);
        textViewSpecialtyView.setText(specialty);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_another);
        view = ((ViewGroup) this.findViewById(android.R.id.content)).getChildAt(0);
        textViewFirstNameView = view.findViewById(R.id.textViewFirstNameView);
        textViewLastNameView = view.findViewById(R.id.textViewLastNameView);
        textViewFacultyNumberView = view.findViewById(R.id.textViewFacultyNumberView);
        textViewSpecialtyView = view.findViewById(R.id.textViewSpecialtyView);

        final Intent myLocalIntent = getIntent();
        final Bundle myBundle = myLocalIntent.getExtras();

        putValuesToFields(myBundle.getString("firstName"), myBundle.getString("lastName"),
                myBundle.getString("facultyNumber"), myBundle.getString("specialty"));


    }
}
