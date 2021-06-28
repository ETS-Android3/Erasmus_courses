package com.example.task_4;

import android.os.Bundle;
import android.os.Handler;
import android.view.View;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import java.util.Locale;

public class MainActivity2 extends AppCompatActivity {

    private TextView contentTextView;

    private long miliseconds = 0;
    private boolean running;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main2);

        contentTextView = findViewById(R.id.contentTextView);
        contentTextView.setText(getIntent().getExtras().getString("content"));

        running = false;
        runTimer();

    }

    public void onClickStart(View view)
    {
        running = true;
    }

    public void onClickStop(View view)
    {
        running = false;
    }

    public void onClickReset(View view)
    {
        miliseconds = 0;
    }

    private void runTimer()
    {

        final TextView timeView = findViewById(R.id.time_view);

        final Handler handler = new Handler();

        handler.post(new Runnable() {
            @Override

            public void run()
            {
                int seconds = (int)(miliseconds / 1000);
                int hours = seconds / 3600;
                int minutes = (seconds % 3600) / 60;
                int secs = seconds % 60;
                int milis = (int)(miliseconds % 1000)/100;

                String time = String.format(Locale.getDefault(),
                                "%d:%02d:%02d.%01d", hours,
                                minutes, secs, milis);

                timeView.setText(time);

                if (running) {
                    miliseconds += 100;
                }

                handler.postDelayed(this, 100);
            }
        });
    }

}