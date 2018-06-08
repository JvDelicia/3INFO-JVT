package com.jvt.a3aetim.sharedpreferences;

import android.content.SharedPreferences;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

	Button btn;
	EditText edit;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		TextView txt  = (TextView)findViewById(R.id.editText2);
		Button btn  = (Button) findViewById(R.id.button);
	}

	public static final String PREFENCIAS_NAME = "Preferencias";
	private boolean teste;
	private void armazenamento(){
		SharedPreferences settings = getSharedPreferences(PREFENCIAS_NAME, 0);
		SharedPreferences.Editor editor = settings.edit();
		editor.commit();
	}

	private void recuperar(){
		SharedPreferences settings = getSharedPreferences(PREFENCIAS_NAME, 0);
		teste = settings.getBoolean("Teste", false);
	}
}
