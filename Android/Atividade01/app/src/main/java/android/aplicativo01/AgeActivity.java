package android.aplicativo01;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;

public class AgeActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_age);

        Intent intent = getIntent();
        String msg = intent.getStringExtra(main_activity.EXTRA_MESSAGE);

        TextView txV_mesagem  = (TextView)findViewById(R.id.txV_mensagem);
        txV_mesagem.setText(msg);
    }

    private void calcular(View view) {
        EditText edT_idade = findViewById(R.id.edT_idade);
        TextView txV_faixa = findViewById(R.id.txV_faixa);

        Byte idade = Byte.parseByte(edT_idade.getText().toString());

        if(idade >= 0 && idade <= 2)
            txV_faixa.setText("Bebê");
        else if(idade >= 3 && idade <= 11)
            txV_faixa.setText("Criança");
        else if(idade >= 12 && idade <= 19)
            txV_faixa.setText("Adolecente");
        else if(idade >= 20 && idade <= 30)
            txV_faixa.setText("Jovem");
        else if(idade >= 31 && idade <= 60)
            txV_faixa.setText("Adulto");
        else
            txV_faixa.setText("Idoso");
    }
}