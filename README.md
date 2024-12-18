# 113-1師大科技系程式語言(Programming Language)
# 授課教師
蔡芸琤老師  &  KID講師
[老師的 GitHub](https://github.com/peculab/Database)
[KID老師的 Miro](https://miro.com/app/board/uXjVKizVakM=/)

## 基本資料
- **姓名**：曾伯宇(Tseng,Po-Yu)
- **系級**：科技系碩士班三年級
- **學號**：61171036H

## 課程筆記區
- **第一階段**
1. 建立新的Unity專案練習 [專案網址](https://github.com/PoyuTseng/NTNU1131ProgrammingLanguage_61171036H)
2. 下載與上課不同的場景素材
3. 使用素材設計遊戲場景 
4. 截圖遊戲場景
5. 下周上課會說明作業上傳方式

- **第二階段**
1. 延續上周的作業專案
2. 升級至URP
3. 下載與上課不同的角色素材
4. 設定至少三個動畫檔
5. 錄影上傳至作業區：作業_2工作表內

- **第三階段**
1. 延續上周的作業專案
2. 添加輸入欄位介面(使用繁體字)
3. 建立NPC，資料並設定要分析的句子至少三句
4. 建立NPC控制器攜帶NPC，資料與動畫控制器
5. 將NPC Controller腳本截圖
6. 上傳製作業區內：作業_3工作表內



   
## 作業連結區
- **※H.W1※**: [專案連結](https://github.com/PoyuTseng/NTNU1131ProgrammingLanguage_61171036H)
- **HW01階段性完成日誌**
 
- 建立Unity新專案
- 下載與上課不同的場景素材
- 使用素材設計布置遊戲場景[場景截圖](https://drive.google.com/file/d/1TWoLwlihKdoksunHUTe-HH7a3JtkwsVI/view?usp=drive_link)
- 匯入角色素材
1. 半獸人騎士[場景截圖](https://drive.google.com/file/d/1MxuEvD-NUqEESYTdQGYwRwNGXg2RKHMx/view?usp=drive_link)
2. 戰士[場景截圖](https://drive.google.com/file/d/1s3YcPGN52x0M_NYHfYgoXgMIDWPgAKKQ/view?usp=drive_link)
3. 農夫[場景截圖](https://drive.google.com/file/d/14n2lU0YH-2SHwD58HNCBNPLlncN9rvqn/view?usp=drive_link)
4. 獵犬[場景截圖](https://drive.google.com/file/d/15crbkMwldZD7WQ8ADZ0egsMg1_pel1vd/view?usp=drive_link)
 

- **※H.W2※**: [Video](https://drive.google.com/file/d/1Hl8CjZ8ij5JtKv832gpuW3qJF2h_DegW/view?usp=sharing) 
- **HW02階段性完成日誌**
 
- 添加3D角色物件素材
- 選用半獸人騎士(滿足條件)
- 具備三種動作模式
- 設置設定角色對應動作並執行預覽[路徑模式](https://drive.google.com/file/d/1Ftql0ul34rOSrEcZe-IlPxH6zX0oMqTv/view?usp=drive_link)
1. 慢步前進
2. 跑步行進
3. 攻擊
4. 跑步-攻擊-走路
 

- **※H.W3※**: [作業截圖](https://drive.google.com/file/d/132QGlb60tzutg7H-MO6CKb5O7I5I9jGj/view?usp=drive_link)[作業截圖](https://drive.google.com/file/d/1MoMX60Fbkb0nmXfFZB0K_nO708ramqYj/view?usp=drive_link)
- **HW03階段性完成日誌**
 
- 設定角色動作對應名詞
- 添加輸入欄位介面(使用繁體字)
- 建立NPC，資料並設定要分析的句子
- 建立NPC控制器攜帶NPC，資料與動畫控制器
- 串聯角色動作路徑

    
-
- 
## 專題連結區
- [專題連結](超連結)
[構想連結](https://github.com/PoyuTseng/1131PL/blob/main/%E6%9C%9F%E6%9C%AB%E5%B0%88%E9%A1%8C%E6%A7%8B%E6%83%B3%E8%88%87%E4%BF%AE%E6%AD%A3%E8%AA%BF%E6%95%B4%E7%B4%80%E9%8C%84.docx)
[專案打包檔案](https://drive.google.com/drive/folders/1OgB4QQrgQBfI_saPQe-SCELBN3rAxxSB?usp=drive_link)
#### 1. 專案概述
- **專案名稱**: Unity角色對戰系統
- **開發目標**:  
  以擲骰子模擬角色對戰的遊戲系統，實現動態攻擊判定、傷害計算，以及角色間的對話互動。整合 HuggingFace 模型生成對話，提升遊戲沉浸感。  
- **開發環境與工具**:  
  - **程式語言**: C#
  - **遊戲引擎**: Unity
  - **外部工具**: HuggingFace（語言生成模型），ModelManager（模型管理與推理部署）
  - **測試工具**: Visual Studio Code
  - **硬體需求**: 藍牙骰子
- **最終成果**:  
  因開發過程中主力電腦多次藍屏當機，無法完成全面整合。最終透過借用他人電腦完成程式邏輯與基本互動功能，並以文字模擬方式進行展示。

---

#### 2. 開發階段與成果
1. **構思與規劃**  
   - **遊戲核心規則**:  
     利用骰子點數進行對戰判定，分為以下五種情境：
     1. **普通命中**: 點數較高者對對方造成基礎傷害。
     2. **暴擊命中**: 點數為6且較高者造成加倍傷害。
     3. **弱化攻擊**: 雙方點數相同時，彼此造成減半傷害。
     4. **普通迴避**: 點數較低者受到普通攻擊。
     5. **暴擊迴避**: 對方點數為6且較高時造成暴擊。
   - **初始設定**:  
     - A與B初始生命值（HP）均為50。  
     - 每回合根據骰子結果更新生命值，直到任一角色生命值降為0。

2. **程式邏輯實作**  
   - **邏輯模組**:  
     - 擲骰：使用 `Random.Next` 生成點數模擬骰子擲骰過程。
     - 攻擊計算：根據五種情境進行傷害倍率計算。
     - 回合控制：顯示每回合輸出，包括點數、攻擊結果、傷害量和剩餘生命值。
   - **範例輸出**:  
     ```
     A rolled: 6, B rolled: 4  
     A lands a critical hit! Damage: 9. HPB: 41.  
     ```

3. **Unity整合與互動展示**  
   - 完成角色屬性管理腳本（`PlayerStats.cs`）與戰鬥邏輯腳本（`DiceBattle.cs`）。
   - 將腳本掛載至角色，實現對戰場景的初步互動展示。  
   - 增加生命條模組，動態更新角色生命值狀態。

4. **HuggingFace 模型整合**  
   - **目的**: 為遊戲中角色互動加入自然語言對話，增強遊戲沉浸感。
   - **方法**:  
     - 利用 HuggingFace 的預訓練模型生成對戰時的動態對話，例如攻擊成功、迴避時的反應。
     - 使用 ModelManager 管理 HuggingFace 模型，實現快速調用與部署。
   - **範例對話**:  
     - A命中B時：
       ```
       A: "看來你的運氣還差了一點！"
       B: "哼，下一回合我一定扳回一城！"
       ```
     - 雙方同時命中時：
       ```
       A: "我們這次旗鼓相當！"
       B: "但最後的勝利者只有一個！"
       ```

5. **硬體測試與挑戰**  
   - 嘗試使用藍牙骰子進行硬體互動測試，但因設備頻繁斷連，導致測試效果不佳。
   - 主力電腦在開發過程中多次藍屏，影響穩定性。借用他人電腦後完成核心程式邏輯的展示。

---

#### 3. 最終展示方式
- **程式碼解析與模擬展示**:  
  - 詳細解析程式邏輯，包括角色生命值管理、骰子點數生成與攻擊傷害計算。
  - 使用文字模擬回合制對戰，展示各種可能情境下的遊戲輸出結果。
- **語言生成展示**:  
  - 利用 HuggingFace 模型模擬角色對話，提升觀眾的代入感與互動性。
- **技術挑戰與解決建議**:  
  - **問題**: 硬體不穩定導致進度受阻，開發電腦多次藍屏影響效率。
  - **建議**:  
    - 使用更穩定的硬體或完全依賴軟體模擬環境。
    - 定期備份開發環境，減少突發狀況對進度的影響。
