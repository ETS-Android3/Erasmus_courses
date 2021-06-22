package com.example.task_4;

import android.os.Bundle;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.os.Handler;
import android.view.View;

import android.widget.ProgressBar;

public class MainActivity extends AppCompatActivity {
    private static final int progressBarMax = 100;
    private static final int progressBarStepTimeSleep = 20;

    private static int progress;
    private ProgressBar progressBar;
    private int progressStatus = 0;
    private Handler handler = new Handler();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        progress = 0;
        progressBar = (ProgressBar) findViewById(R.id.progressbar);
        progressBar.setMax(progressBarMax);

        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
//                Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
//                        .setAction("Action", null).show();

                new Thread(new Runnable() {
                    @Override
                    public void run() {
                        handler.postAtFrontOfQueue(new Runnable() {
                            @Override
                            public void run() {
                                progress = 0;
                                progressStatus = 0;
                                progressBar.setProgress(progress);
                                progressBar.setVisibility(View.VISIBLE);
                            }
                        });
                        while (progressStatus < progressBarMax) {
                            progressStatus = doSomeWork();
                            handler.post(new Runnable() {
                                public void run() {
                                    progressBar.setProgress(progressStatus);
                                }
                            });
                        }
                        handler.post(new Runnable() {
                            public void run() {
                                progressBar.setVisibility(View.GONE);
                                Snackbar.make(view, "Done", Snackbar.LENGTH_LONG)
                                        .setAction("Action", null).show();
                            }
                        });
                    }
                    private int doSomeWork() {
                        try {
                            // ---simulate doing some work---
                            Thread.sleep(progressBarStepTimeSleep);
                        } catch (InterruptedException e) {
                            e.printStackTrace();
                        }
                        return ++progress;
                    }
                }).start();

            }
        });
    }

}