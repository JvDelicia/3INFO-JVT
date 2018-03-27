package android.aplicativo01;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class NumbersActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_numbers);
    }

    private void calcular(View view) {
        EditText edT_numero1 = findViewById(R.id.edT_numero1);
        EditText edT_numero2 = findViewById(R.id.edT_numero2);
        EditText edT_numero3 = findViewById(R.id.edT_numero3);
        EditText edT_numero4 = findViewById(R.id.edT_numero4);

        TextView txV_media = findViewById(R.id.txV_media);
        TextView txV_somatorio = findViewById(R.id.txV_somatorio);
        TextView txV_resto1 = findViewById(R.id.txV_resto1);
        TextView txV_resto2 = findViewById(R.id.txV_resto2);
        TextView txV_resto3 = findViewById(R.id.txV_resto3);
        TextView txV_resto4 = findViewById(R.id.txV_resto4);

        Double[] numeros = new Double[4];
        numeros[0] = Double.parseDouble(edT_numero1.getText().toString());
        numeros[1] = Double.parseDouble(edT_numero2.getText().toString());
        numeros[2] = Double.parseDouble(edT_numero3.getText().toString());
        numeros[3] = Double.parseDouble(edT_numero4.getText().toString());

        Double somatorio = 0.0;
        for(byte b = 0; b <= 3; b++) {
            somatorio += numeros[b];
        }
        txV_somatorio.setText(somatorio.toString());

        Double media = somatorio / numeros.length;
        txV_media.setText(media.toString());

        Double[] restos = new Double[4];
        for(byte b = 0; b <= 3; b++)
            restos[b] = somatorio / numeros[b];

        txV_resto1.setText(restos[0].toString());
        txV_resto2.setText(restos[1].toString());
        txV_resto3.setText(restos[2].toString());
        txV_resto4.setText(restos[3].toString());
    }
}