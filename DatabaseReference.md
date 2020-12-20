## 概要
* データベース：SQLite3
* 拡張子：.hmp (HoI4 Modding Project)

## Project Data
* テーブル名：**project_data**

カラム|データ型（SQLite3）|説明|記述例
---|---|---|---
**project_name**|TEXT|プロジェクト名|*Kaiserreich*
**created_at**|-|プロジェクトが作成された日付|*2020-12-12*
**updated_at**|-|プロジェクトが更新された日付|*2020-12-12*
**number_of_countries**|INTGER|プロジェクトに含まれている国の数|*3*
**number_of_ideologies**|INTGER|プロジェクトに含まれているイデオロギーの数|*1*

## Countries Data
* テーブル名：**countries_data**

カラム|データ型（SQLite3）|説明|記述例
---|---|---|---
**id**|INTGER|国家ID|*0*
**country_tag**|TEXT|国家タグ<br>（大文字アルファベット、半角スペース不可、3文字）|*HRE*
**country_name**|TEXT|識別用国名<br>ファイル名に使用されます|*HolyRomanEmpire*
**country_name_neutrality**|TEXT|国名（中道主義）<br>マップの国名ラベルに使用されます|*神聖ローマ帝国*
**country_name_neutrality_def**|TEXT|正式国名（中道主義）|*神聖ローマ帝国*
**country_name_neutrality_adj**|TEXT|通称国名（中道主義）<br>メッセージボックスなどで使用されます|*ローマ*
**country_name_democratic**|TEXT|国名（民主主義）<br>マップの国名ラベルに使用されます|*ローマ共和国*
**country_name_democratic_def**|TEXT|正式国名（民主主義）|*ローマ共和国*
**country_name_democratic_adj**|TEXT|通称国名（民主主義）<br>メッセージボックスなどで使用されます|*ローマ*
**country_name_fascism**|TEXT|国名（ファシズム）<br>マップの国名ラベルに使用されます|*帝政ローマ*
**country_name_fascism_def**|TEXT|正式国名（ファシズム）|*神聖ローマ帝国*
**country_name_fascism_adj**|TEXT|通称国名（ファシズム）<br>メッセージボックスなどで使用されます|*帝政ローマ*
**country_name_communism**|TEXT|国名（共産主義）<br>マップの国名ラベルに使用されます|*ローマ連邦*
**country_name_communism_def**|TEXT|正式国名（共産主義）|*ローマ社会主義共和国連邦*
**country_name_communism_adj**|TEXT|通称国名（共産主義）<br>メッセージボックスなどで使用されます|*ローマ連邦*
**party_name_neutrality**|TEXT|中道主義政党名|*神聖ローマ皇帝*
**party_name_neutrality_long**|TEXT|中道主義政党名（正式名）|*神聖ローマ皇帝*
**party_name_democratic**|TEXT|民主主義政党名|*民主党*
**party_name_democratic_long**|TEXT|民主主義政党名（正式名）|*民主党*
**party_name_fascism**|TEXT|ファシズム政党名|*NSRAP*
**party_name_fascism_long**|TEXT|ファシズム政党名（正式名）|*国家社会主義ローマ労働者党*
**party_name_communism**|TEXT|共産主義政党名|*共産党*
**party_name_communism_long**|TEXT|共産主義政党名（正式名）|*共産党*
**capital_state_id**|INTGER|首都を含む州ID|*64*
**initial_teach_slot**|INTGER|初期研究スロット数|*4*
**initial_stability**|INTGER|初期安定度（%）|*56*
**initial_war_coop**|INTGER|初期戦争協力度（%）|*87*
**initial_political_power**|INTGER|初期政治力|*150*
**initial_transport**|INTGER|初期輸送船数|*453*
**graphical_culture**|TEXT|汎用顔グラフィックの地域設定|*west_europe*
**initial_ideology**|TEXT|初期イデオロギー|*neutrality*
**last_election_at**|-|最後に選挙を行った日付|*1936-01-01*
**election_interval**|INTGER|選挙を行う間隔（ヶ月）|*48*
**is_no_election**|INTGER|選挙なし<br>0：false, 0以外：true|*0*
**color_r**|INTGER|Rカラーコード（0~255）|*43*
**color_g**|INTGER|Gカラーコード（0~255）|*63*
**color_b**|INTGER|Bカラーコード（0~255）|*43*
**party_support_neutrality**|INTGER|中道主義政党支持率（%）<br>（すべてのイデオロギー支持率を合計100%ちょうどにする必要があります）|*100*
**party_support_democratic**|INTGER|民主主義政党支持率（%）<br>（すべてのイデオロギー支持率を合計100%ちょうどにする必要があります）|*0*
**party_support_fascism**|INTGER|ファシズム政党支持率（%）<br>（すべてのイデオロギー支持率を合計100%ちょうどにする必要があります）|*0*
**party_support_communism**|INTGER|共産主義政党支持率（%）<br>（すべてのイデオロギー支持率を合計100%ちょうどにする必要があります）|*0*