package com.example.task_1_1;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class AnotherActivity extends AppCompatActivity {
    TextView textViewFirstNameView = null;
    TextView textViewLastNameView = null;
    TextView textViewFacultyNumberView = null;
    TextView textViewSpecialtyView = null;
    TextView textViewGradeView = null;
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
        textViewGradeView = view.findViewById(R.id.textViewGradeView);

        final Intent myLocalIntent = getIntent();
        final Bundle myBundle = myLocalIntent.getExtras();

        putValuesToFields(myBundle.getString("firstName"), myBundle.getString("lastName"),
                myBundle.getString("facultyNumber"), myBundle.getString("specialty"));

        ((Button) findViewById(R.id.buttonGetMarks)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent customIntent = new Intent(AnotherActivity.this, SecondAnotherActivity.class);
                startActivityForResult(customIntent, 1);
            }
        });
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        Bundle myResultBundle = data.getExtras();
        textViewGradeView.setText(myResultBundle.getString("returnGrade"));

    };
}
