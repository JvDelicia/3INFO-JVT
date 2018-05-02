package com.jvt.a3aetim.atividade02;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
	}

	void searchUrl(View view) {
		EditText edT = (EditText)findViewById(R.id.edT_url);
		String content = edT.getText().toString();

		Intent intent;
		if(android.text.TextUtils.isDigitsOnly(content))
			intent = new Intent(Intent.ACTION_DIAL, content);
		else
			intent = new Intent(Intent.ACTION_VIEW, content);
		startActivity(intent);
	}
}
