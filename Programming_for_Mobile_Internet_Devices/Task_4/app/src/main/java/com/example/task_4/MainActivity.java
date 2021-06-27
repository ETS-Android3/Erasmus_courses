package com.example.task_4;

import android.content.Intent;
import android.os.Bundle;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.google.android.material.snackbar.Snackbar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;

import android.os.Handler;
import android.os.Message;
import android.view.View;

import android.widget.EditText;
import android.widget.ProgressBar;

import java.util.Random;

public class MainActivity extends AppCompatActivity {
    private static final int progressBarMax = 30;
    private static final int progressBarStepTimeSleep = 20;

    private static int progress;
    private ProgressBar progressBar;
    private int progressStatus = 0;
    private static Handler handler = null;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        handler = new Handler(){
            @Override
            public void handleMessage(Message msg) {
                View view = getWindow().getDecorView().findViewById(android.R.id.content);
                Boolean result = msg.getData().getBoolean("success");
                if(result){
                    Intent customIntent = new Intent(MainActivity.this, MainActivity2.class);
                    Bundle dataBundle = new Bundle();
                    String contentStr = ((EditText) findViewById(R.id.contentEditText)).getText().toString();
                    dataBundle.putString("content", contentStr);
                    customIntent.putExtras(dataBundle);
                    startActivity(customIntent);

                } else {
                    String resultStr = String.format("Sending failed");
                    Snackbar.make(view, resultStr, Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();
                }

            }
        };


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
                                Message message = handler.obtainMessage();
                                Bundle b = new Bundle ();
                                b.putBoolean("success", Math.random() > 0.5);
                                message.setData(b);
                                handler.sendMessage(message);
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