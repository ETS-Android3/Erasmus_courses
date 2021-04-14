package com.example.task_1_1;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class SecondAnotherActivity extends AppCompatActivity {
    private Integer numberOfMarks;
    private Integer sumOfMarks;
    private Float meanOfMarks;

    private void updateStatistics(){
        ((TextView) this.findViewById(R.id.textViewMarksNumberView)).setText(numberOfMarks.toString());
        ((TextView) this.findViewById(R.id.textViewSumView)).setText(sumOfMarks.toString());
        ((TextView) this.findViewById(R.id.textViewMeanView)).setText(String.format("%.2f", meanOfMarks));
    }

    private void initMarks(){
        numberOfMarks = 0;
        sumOfMarks = 0;
        meanOfMarks = 0f;
    }
    private void updateMarks(){
        numberOfMarks++;
        sumOfMarks += getRandomNumber(1,6);
        meanOfMarks = (float)sumOfMarks/(float)numberOfMarks;
        updateStatistics();
    }

    public int getRandomNumber(int min, int max) {
        return (int) ((Math.random() * (max - min)) + min);
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_second_another);
        initMarks();
        updateMarks();
        ((Button) findViewById(R.id.buttonGetMarks)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                updateMarks();
            }
        });
        ((Button) findViewById(R.id.buttonAcceptMarks)).setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                finish();
            }
        });
    }

    @Override
    public void finish() {
        // Prepare data intent
        Intent data = new Intent();
        data.putExtra("returnGrade", String.format("%.2f", meanOfMarks));
        setResult(RESULT_OK, data);
        super.finish();
    }
}
